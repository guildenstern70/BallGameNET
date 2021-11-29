/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using BallGameNET.Data;

namespace BallGameNET.Services;

public interface ISiteUserService
{
    void AddUser(string username, string password);
    SiteUser? GetUser(string username);
    bool IsUsernameAvailable(string username);
    bool CheckLogin(string username, string password);
}
