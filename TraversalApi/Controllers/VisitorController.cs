﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraversalApi.DAL.Context;
using TraversalApi.DAL.Entities;

namespace TraversalApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var context = new VisitorContext())
            {
                var value=context.Visitors.ToList();
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult VisitorAdd(Visitor visitor)
        {
            using(var context = new VisitorContext())
            {
                context.Add(visitor);
                context.SaveChanges();
                return Ok();
            }
        }

        [HttpGet("{id}")]
        public IActionResult VisitorGet(int id)
        {
            using(var context=new VisitorContext())
            {
                var value = context.Visitors.Find(id);
                if (value==null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(value);
                }
            }
        }
        [HttpDelete("id")]
        public IActionResult VisitorDelete(int id)
        {
            using (var context = new VisitorContext())
            {
                var value = context.Visitors.Find(id);
                if (value == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(value);
                    context.SaveChanges() ;
                    return Ok();
                }
            }
        }
        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            using (var context = new VisitorContext())
            {
                var value = context.Find<Visitor>(visitor.VisitorId);  
                if (value==null)
                {
                    return NotFound();
                }
                else
                {
                    value.Name = visitor.Name;
                    value.Surname = visitor.Surname;
                    value.City = visitor.City;
                    value.Country = visitor.Country;
                    value.Mail = visitor.Mail;
                    context.Update(value);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}