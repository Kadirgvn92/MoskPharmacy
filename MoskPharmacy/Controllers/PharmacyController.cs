using Microsoft.AspNetCore.Mvc;
using MoskPharmacy.Models;
using MoskPharmacy.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace MoskPharmacy.Controllers;
public class PharmacyController : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = new RestClient("https://api.collectapi.com/health/dutyPharmacy?ilce=Nil%C3%BCfer&il=Bursa");
        var request = new RestRequest(Method.GET);
        request.AddHeader("authorization", "apikey 3vLvr8BLRuJZH5KJDssMMM:3s0zddCcs13UHM3tSE1TPp");
        request.AddHeader("content-type", "application/json");
        var response = await client.ExecuteAsync(request);
        if (response.IsSuccessful)
        {
            var responseContent = JsonConvert.DeserializeObject<dynamic>(response.Content);
            var pharmacyList = new List<PharmacyViewModel>();

            foreach (var pharmacyJson in responseContent.result)
            {
                var pharmacyViewModel = new PharmacyViewModel
                {
                    Name = pharmacyJson.name,
                    District = pharmacyJson.dist,
                    Address = pharmacyJson.address,
                    Phone = pharmacyJson.phone,
                    Location = pharmacyJson.loc
                };

                pharmacyList.Add(pharmacyViewModel);
            }



            return View(pharmacyList);
        }
        return View();
    }
}
