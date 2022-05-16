using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume_Asp.Data;
using MyResume_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyResume_AspContext _context;

        public AdminController(MyResume_AspContext context)
        {
            _context = context;
        }
        public IActionResult EditInfo([Bind("Id,FullName,Age,Degree,Email,Freelance,Birthday,Website,Phone,City")] MyInformation myInformation)
        {

            if (_context.MyInformation.Count() == 0)
            {
                _context.MyInformation.Add(myInformation);
            }
            else
            {
                myInformation.Id = 1;
                _context.MyInformation.Update(myInformation);
            }

            _context.SaveChanges();
            return View(_context.MyInformation.First());
        }
        public IActionResult EditAboutMe([Bind("Id,Title,Dscription")] AboutMe aboutme)
        {

            if (_context.AboutMe.Count() == 0)
            {
                _context.AboutMe.Add(aboutme);
            }
            else
            {
                aboutme.iD = 1;
                _context.AboutMe.Update(aboutme);
            }
            _context.SaveChanges();
            return View(_context.AboutMe.First());
        }
        public IActionResult EditFacts([Bind("Id,HappyClients,Projects,HoursOfSupport,Awards")] Facts facts)
        {

            if (_context.Facts.Count() == 0)
            {
                _context.Facts.Add(facts);
            }
            else
            {
                facts.Id = 1;
                _context.Facts.Update(facts);
            }
            _context.SaveChanges();
            return View(_context.Facts.First());
        }
        public IActionResult EditMySkills([Bind("Id,Info")] MySkills MySkills)
        {

            if (_context.MySkills.Count() == 0)
            {
                _context.MySkills.Add(MySkills);
            }
            else
            {
                MySkills.Id = 1;
                _context.MySkills.Update(MySkills);
            }
            _context.SaveChanges();
            return View(_context.MySkills.First());
        }
        public IActionResult EditSkill([Bind("Id,NameSkill,Learned,IdSkillSet")] Skill MySkill)
        {
            MySkill.IdSkillSet = _context.MySkills.First().Id;
            if (_context.MySkills.Include(x => x.SkillsList).First().SkillsList.Count() != 0)
            {
                _context.Skill.Add(MySkill);
                _context.SaveChanges();
                return View();
            }
            else
            {
                _context.Skill.Update(MySkill);
                _context.SaveChanges();
                return View(MySkill);
            }
        }


        //public IActionResult EditResume([Bind("Id,Dscription")] Resume resume,string ResumeSide)
        //{
        //    if (ResumeSide == "Right")
        //    {
        //        resume.Id = 1;
        //        if (_context.Resume.Count() == 0)
        //        {
        //            _context.Resume.Add(resume);
        //        }
        //        else
        //        {
        //            _context.Resume.Update(resume);
        //        }
        //    }
        //    else if (ResumeSide == "Left")
        //    {
        //        resume.Id = 2;
        //        if (_context.Resume.Count() == 0)
        //        {
        //            _context.Resume.Add(resume);
        //        }
        //        else
        //        {
        //            _context.Resume.Update(resume);
        //        }
        //    }
        //    _context.SaveChanges();
        //    return View(_context.Resume.First());
        //}
        //public IActionResult EditResumeSec([Bind("Id,Title,Text,ResumeId")] ResumeSection resumeSection)
        //{
        //    resumeSection.Id = 1;
        //    if (_context.ResumeSection.Count() == 0)
        //    {
        //        _context.ResumeSection.Add(resumeSection);
        //    }
        //    else
        //    {
        //        _context.ResumeSection.Update(resumeSection);
        //    }
        //    _context.SaveChanges();
        //    return View(_context.Resume.First());
        //}
    }
}
