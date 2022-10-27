/*
Carlos Felipe
10/27/22
Restaurant Picker - Endpoint
CODE: This program picks a random restaurant based on the category chosen
Reviewed by Daniel Decoito: The api and code work really well. I liked that you used routes to get the other catagories kudos. 
*/

using Microsoft.AspNetCore.Mvc;

namespace FelipeCRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("Asian")]
    public string Asian(){
    string[] asian = {"Siamese Street Thai Restaurant", "Tasty Pot", "Saigon Bowl Noodle House", "BonChon", "Domo", "Shirasoni Japanese Steakhouse", "Ramen 101 Stockton", "Huong Lan", "GK Mongolian BBQ", "Best Lumpia"};
    Random rnd = new Random();
    int asianNum = rnd.Next(asian.Length);
    return "You should try out " + asian[asianNum];
    }

    [HttpGet]
    [Route("Italian")]
    public string Italian(){
    string[] italian = {"Angelina's Spaghetti House","Eric's New York Style Pizza","De Vinci's","Romano's Macaroni Grill","De Vega Brothers","Dante's","David's New York Style Pizza","Eddie's Pizza","Olive Garden","Gian's Delicatessen"};
    Random rnd = new Random();
    int italianNum = rnd.Next(italian.Length);
    return "What about " + italian[italianNum];
    }

    [HttpGet]
    [Route("Mexican")]
    public string Mexican(){
    string[] mexican = {"Nena's Mexican Cuisine","Maria's Cafe","Taqueria Chapala","Taqueria La Estrella","Taqueria Carolina","Miguel's Mexican Restaurant","Tepa Taqueria","La Baja Birrieria Tijuana","Cancún Restaurant","Tio Pepe's II",};
    Random rnd = new Random();
    int mexicanNum = rnd.Next(mexican.Length);
    return "Go eat at " + mexican[mexicanNum];
    }

}
