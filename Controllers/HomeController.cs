using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escapeRoom.Models;

namespace escapeRoom.Controllers;

public class HomeController : Controller
{
    public List<Group> ReservationList = new List<Group>();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Reservations(string name, string phone, int size)
    {

        if(phone != "" && phone != null && size < 7 && size > 0)
        {
            Group newReservation = new Group(name, phone, size);
            ReservationList.Add(newReservation);

        }

        return View();
    }


}

