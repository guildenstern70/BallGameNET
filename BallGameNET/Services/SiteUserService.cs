/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using BallGameNET.Data;

namespace BallGameNET.Services;


public class SiteUserService : ISiteUserService
{

    private readonly List<SiteUser> _users = new()
    {
        new SiteUser("guest", "guest"),
        new SiteUser("alessio", "doctor")
    };

    public bool IsUsernameAvailable(string username)
    {
        if (username.Length < 2)
            return false;
        if (!username.Contains('@'))
            return false;
        return this.GetUser(username) == null;
    }

    public bool CheckLogin(string username, string password)
    {
        var user = this.GetUser(username);
        return user != null && user.Password.Equals(password);
    }

    public SiteUser? GetUser(string username)
    {
        return this._users.FirstOrDefault(x => x.Username == username);
    }

    public void AddUser(string username, string password)
    {
        this._users.Add(new SiteUser(username, password));
    }

}
