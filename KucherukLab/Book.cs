﻿public class Book : Product
{
    public int Pages { get; set; }      
    public string Publisher { get; set; } 
    public string Authors { get; set; }   

    public Book(decimal price, string originCountry, string name, DateTime packagingDate, string description,
                int pages, string publisher, string authors)
        : base(price, originCountry, name, packagingDate, description)
    {
        Pages = pages;
        Publisher = publisher;
        Authors = authors;
    }
}
