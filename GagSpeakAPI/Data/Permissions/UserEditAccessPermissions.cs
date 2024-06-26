using System.ComponentModel.DataAnnotations;

namespace GagSpeak.API.Data.Permissions;

public class UserEditAccessPermissions
{
    // unique permissions stored here:
    public bool CommandsFromFriendsAllowed { get; set; } = false; // Global
    public bool CommandsFromPartyAllowed { get; set; } = false; // Global
    public bool LiveChatGarblerActiveAllowed { get; set; } = false; // Global
    public bool LiveChatGarblerLockedAllowed { get; set; } = false; // Global
    public bool ExtendedLockTimesAllowed { get; set; } = false;
    public bool MaxLockTimeAllowed { get; set; } = false;

    // unique permissions for the wardrobe
    public bool WardrobeEnabledAllowed { get; set; } = false; // Global
    public bool ItemAutoEquipAllowed { get; set; } = false; // Global
    public bool RestraintSetAutoEquipAllowed { get; set; } = false; // Global
    public bool LockGagStorageOnGagLockAllowed { get; set; } = false; // Global
    public bool ApplyRestraintSetsAllowed { get; set; } = false;
    public bool LockRestraintSetsAllowed { get; set; } = false;
    public bool MaxAllowedRestraintTimeAllowed { get; set; } = false;
    public bool RemoveRestraintSetsAllowed { get; set; } = false;

    // unique permissions for the puppeteer
    public bool PuppeteerEnabledAllowed { get; set; } = false; // Global
    public bool AllowSitRequestsAllowed { get; set; } = false;
    public bool AllowMotionRequestsAllowed { get; set; } = false;
    public bool AllowAllRequestsAllowed { get; set; } = false;

    // unique Moodles permissions
    public bool MoodlesEnabledAllowed { get; set; } = false; // Global
    public bool AllowPositiveStatusTypesAllowed { get; set; } = false;
    public bool AllowNegativeStatusTypesAllowed { get; set; } = false;
    public bool AllowSpecialStatusTypesAllowed { get; set; } = false;
    public bool PairCanApplyOwnMoodlesToYouAllowed { get; set; } = false;
    public bool PairCanApplyYourMoodlesToYouAllowed { get; set; } = false;
    public bool MaxMoodleTimeAllowed { get; set; } = false;
    public bool AllowPermanentMoodlesAllowed { get; set; } = false;

    // unique permissions for the toybox
    public bool ToyboxEnabledAllowed { get; set; } = false; // Global
    public bool LockToyboxUIAllowed { get; set; } = false; // Global
    public bool ToyIsActiveAllowed { get; set; } = false; // Global
    public bool SpatialVibratorAudioAllowed { get; set; } = false; // Global
    public bool ChangeToyStateAllowed { get; set; } = false;
    public bool CanControlIntensityAllowed { get; set; } = false;
    public bool VibratorAlarmsAllowed { get; set; } = false;
    public bool CanUseRealtimeVibeRemoteAllowed { get; set; } = false;
    public bool CanExecutePatternsAllowed { get; set; } = false;
    public bool CanExecuteTriggersAllowed { get; set; } = false;
    public bool CanCreateTriggersAllowed { get; set; } = false;
    public bool CanSendTriggersAllowed { get; set; } = false;
}