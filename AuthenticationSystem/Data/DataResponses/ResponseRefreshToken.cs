﻿namespace AuthenticationSystem.Data.DataResponses;

public class ResponseRefreshToken
{
    public string Username { get; set; } = string.Empty;
    public string TokenRefresh { get; set; } = string.Empty;
}