﻿namespace Gagspeak.API.Data.Enum;

/// <summary>
/// Enum that determines the state of a current pairing with other clients.
/// Ensures the connection is mutual.
/// </summary>
public enum IndividualPairStatus
{
    None,
    OneSided,
    Bidirectional
}