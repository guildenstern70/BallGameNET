/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

namespace BallGameNET.Data;

public class SiteUser
{
    public SiteUser()
    {
        this.Username = "";
        this.Password = "";
    }

    public SiteUser(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }

    public string Username { get; set; }
    public string Password { get; set; }
}
