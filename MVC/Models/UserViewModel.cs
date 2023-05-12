namespace MVC.Models;

public class UserViewModel
{
    public int Id{get;set;}
    public string Name{get;set;} = "Angelina";
    public string PhoneNumber{get;set;}
    public string Email{get;set;}
    public int Age{get;set;} = 30;
    public string UserInlog{get;set;}
    public List<CORE.Entities.Challenge> AvailableChallenges{get;set;}
}
