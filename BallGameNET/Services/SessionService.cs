/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

namespace BallGameNET.Services;

public class SessionService : ISessionService
{
    private readonly ILocalStorageService _localStorageService;
    private readonly ILogger _logger;

    private readonly string _userKey = "session-user";

    public SessionService(ILocalStorageService localStorageService,
        ILogger<SessionService> logService)
    {
        this._localStorageService = localStorageService;
        this._logger = logService;
    }


    public async Task<string?> GetLoggedUser()
    {
        return await this._localStorageService.GetItem<string>(this._userKey);
    }

    public async Task Login(string username)
    {
        this._logger.LogInformation("Setting Login info for user {Username}", username);
        await this._localStorageService.SetItem(this._userKey, username);
    }

    public async void Logout()
    {
        this._logger.LogInformation("Logging out user");
        await this._localStorageService.RemoveItem(this._userKey);
    }


}
