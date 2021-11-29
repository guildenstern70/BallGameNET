/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

namespace BallGameNET.Services;

public interface ISessionService
{
    Task<string?> GetLoggedUser();
    Task Login(string username);
    void Logout();
}
