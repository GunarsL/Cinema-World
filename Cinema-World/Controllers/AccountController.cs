using Cinema_World.Data;
using Cinema_World.Data.Static;
using Cinema_World.Data.ViewModels;
using Cinema_World.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Cinema_World.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        public IActionResult Login()
        {
            var response = new LoginViewModel();


            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if(user !=null )
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if(passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index", "Cinematography");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again.";
                return View(loginViewModel);
            }

            TempData["Error"] = "Wrong credentials. Please, try again.";
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            var response = new RegisterViewModel();


            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            var userMail = await _userManager.FindByEmailAsync(registerViewModel.Email);
            if(userMail != null)
            {
                TempData["Error"] = "Email address is unavailable";
                return View(registerViewModel);
            }

            var userName = await _userManager.FindByNameAsync(registerViewModel.UserName);
            if(userName != null)
            {
                TempData["Error"] = "Username is unavailable";
                return View(registerViewModel);
            }

            var newUser = new ApplicationUser()
            {
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email
            };

            var newUserResponse = await _userManager.CreateAsync(newUser, registerViewModel.Password);
            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            using (MailMessage mail = new MailMessage("leitans.g@gmail.com", registerViewModel.Email))
            {
                var cwURL = "https://cinema-world.azurewebsites.net/Cinematography";

                mail.Subject = "Cinema World Registration";
                string body = "Hello " + registerViewModel.UserName + ",";
                body += "<br /><br />Thank you for registering at Cinema World";
                body += "<br /><a href = '" + string.Format("{0}",cwURL) + "'>Click here to browser our cinematograhy content</a>";
                body += "<br /><br />Thank you!";
                body += "<br />Sincerely, Cinema World team";
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential networkCredential = new NetworkCredential("leitans.g@gmail.com", "edbqzyisoangvivj");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = networkCredential;
                smtp.Port = 587;
                smtp.Send(mail);
            }

            return View("RegisterDone");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Cinematography");
        }
    }
}
