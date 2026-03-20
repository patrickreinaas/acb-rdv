namespace QuazalWV
{
    /// <summary>
    /// Property IDs used as game session attributes.
    /// </summary>
    public enum SessionParam
    {
        SearchStrategy = 0,
        MaxPublicSlots = 3,
        MaxPrivateSlots = 4,
        CurrentPublicSlots = 5,
        CurrentPrivateSlots = 6,
        IsPrivate = 7,
        FreePublicSlots = 0x32,
        FreePrivateSlots = 0x33,
        CxbCrcSum = 0x64,           // Version
        MapID = 0x65,
        GamerLevel = 0x66,
        LanguageID = 0x67,          // Language
        RegionID = 0x68,            // Region
        GamerLevelMin = 0x69,
        GamerLevelMax = 0x6A,
        /// <summary>
        /// Seemingly always 1.
        /// </summary>
        GameType = 0x6B,
        GameMode = 0x6C,
        MaximumCurrentSlot = 0x6D,
        SessionType = 0x6E,
        Accessibility = 0x6F,
        DlcID = 0x70,
        SessionStarted = 0x71,
        SessionNatType = 0x72,
        PunkbusterActive = 0x73     // SessionLevel
    }
}
