/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BOXAMBIENCEPLAY = 829164566U;
        static const AkUniqueID BOXDROP = 3810078911U;
        static const AkUniqueID BOXDROPCUE = 241339208U;
        static const AkUniqueID BOXPICKUP = 2671589300U;
        static const AkUniqueID BOXPICKUPCUE = 4115829741U;
        static const AkUniqueID BOXSEGMENTDOWNCUE = 3547374172U;
        static const AkUniqueID BOXSEGMENTUPCUE = 1360996149U;
        static const AkUniqueID ENTERINDOORS = 1721219483U;
        static const AkUniqueID ENTERINDOORSTUNNEL = 1113956849U;
        static const AkUniqueID ENTEROUTDOORS = 3070671186U;
        static const AkUniqueID ENTERTUNNEL = 2811934447U;
        static const AkUniqueID FOOTSTEP = 1866025847U;
        static const AkUniqueID FOOTSTEPJUMP = 4234937615U;
        static const AkUniqueID FOOTSTEPLAND = 1877319332U;
        static const AkUniqueID FOOTSTEPVAMPCOOLDOWN = 4288247056U;
        static const AkUniqueID HARPOONAMBIENCEPLAY = 561183332U;
        static const AkUniqueID HARPOONAMBIENCESTOP = 3333733726U;
        static const AkUniqueID HARPOONFIRERETURN = 2421633396U;
        static const AkUniqueID HARPOONGRABSUCCESS = 2837856117U;
        static const AkUniqueID HARPOONPICKUP = 2867011390U;
        static const AkUniqueID HARPOONRECEIVED = 757170495U;
        static const AkUniqueID LEVELBIGROOMREVEAL = 3672941687U;
        static const AkUniqueID LEVELSTART = 3372421815U;
        static const AkUniqueID MUSICSTART = 1122283870U;
        static const AkUniqueID SFXSTART = 1661560854U;
        static const AkUniqueID STEPOFFBED = 157353963U;
        static const AkUniqueID STEPONBED = 135348085U;
        static const AkUniqueID TREEAMBIENCEPLAY = 1973723167U;
        static const AkUniqueID WORLDKEY_A5 = 3724088773U;
        static const AkUniqueID WORLDKEY_A6 = 3724088774U;
        static const AkUniqueID WORLDKEY_B5 = 3774421660U;
        static const AkUniqueID WORLDKEY_B6 = 3774421663U;
        static const AkUniqueID WORLDKEY_C5 = 3757644067U;
        static const AkUniqueID WORLDKEY_C6 = 3757644064U;
        static const AkUniqueID WORLDKEY_D5 = 3807976954U;
        static const AkUniqueID WORLDKEY_D6 = 3807976953U;
        static const AkUniqueID WORLDKEY_E5 = 3791199241U;
        static const AkUniqueID WORLDKEY_E6 = 3791199242U;
        static const AkUniqueID WORLDKEY_F4 = 3841532097U;
        static const AkUniqueID WORLDKEY_F5 = 3841532096U;
        static const AkUniqueID WORLDKEY_F6 = 3841532099U;
        static const AkUniqueID WORLDKEY_G4 = 3824754518U;
        static const AkUniqueID WORLDKEY_G5 = 3824754519U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace BOXOPENINGSTINGERSTATE
        {
            static const AkUniqueID GROUP = 1038281861U;

            namespace STATE
            {
                static const AkUniqueID MUTED = 3791155954U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace BOXOPENINGSTINGERSTATE

        namespace BOXSTATE
        {
            static const AkUniqueID GROUP = 2558423223U;

            namespace STATE
            {
                static const AkUniqueID BOXHELD = 2060468149U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace BOXSTATE

        namespace HARPOONFIRED
        {
            static const AkUniqueID GROUP = 379189110U;

            namespace STATE
            {
                static const AkUniqueID HASFIRED = 2378879461U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace HARPOONFIRED

        namespace HARPOONSTATE
        {
            static const AkUniqueID GROUP = 1363879777U;

            namespace STATE
            {
                static const AkUniqueID HARPOONHELD = 515864255U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace HARPOONSTATE

        namespace ROOM_B
        {
            static const AkUniqueID GROUP = 1941896135U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PASSED = 2764605217U;
            } // namespace STATE
        } // namespace ROOM_B

        namespace ROOM_C
        {
            static const AkUniqueID GROUP = 1941896134U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PASSED = 2764605217U;
            } // namespace STATE
        } // namespace ROOM_C

        namespace ROOM_TYPE
        {
            static const AkUniqueID GROUP = 1777631295U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OUTDOORS = 2730119150U;
                static const AkUniqueID TUNNEL = 3059984139U;
            } // namespace STATE
        } // namespace ROOM_TYPE

        namespace WORLDKEYSENABLED
        {
            static const AkUniqueID GROUP = 3156432362U;

            namespace STATE
            {
                static const AkUniqueID ENABLED = 4174102348U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace WORLDKEYSENABLED

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPTYPE
        {
            static const AkUniqueID GROUP = 1458816175U;

            namespace SWITCH
            {
                static const AkUniqueID BED = 446279778U;
                static const AkUniqueID CONCRETE = 841620460U;
                static const AkUniqueID GLASS = 2449969375U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID GRAVEL = 2185786256U;
                static const AkUniqueID METAL = 2473969246U;
                static const AkUniqueID WOOD = 2058049674U;
            } // namespace SWITCH
        } // namespace FOOTSTEPTYPE

        namespace VAMPFOOTSTEP
        {
            static const AkUniqueID GROUP = 1468846155U;

            namespace SWITCH
            {
                static const AkUniqueID DISABLED = 3248502869U;
                static const AkUniqueID ENABLED = 4174102348U;
            } // namespace SWITCH
        } // namespace VAMPFOOTSTEP

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID BOXSEGMENT = 3762319931U;
        static const AkUniqueID FOOTSTEPWEIGHT = 3587782899U;
        static const AkUniqueID PLAYBACK_RATE = 1524500807U;
        static const AkUniqueID RPM = 796049864U;
        static const AkUniqueID SS_AIR_FEAR = 1351367891U;
        static const AkUniqueID SS_AIR_FREEFALL = 3002758120U;
        static const AkUniqueID SS_AIR_FURY = 1029930033U;
        static const AkUniqueID SS_AIR_MONTH = 2648548617U;
        static const AkUniqueID SS_AIR_PRESENCE = 3847924954U;
        static const AkUniqueID SS_AIR_RPM = 822163944U;
        static const AkUniqueID SS_AIR_SIZE = 3074696722U;
        static const AkUniqueID SS_AIR_STORM = 3715662592U;
        static const AkUniqueID SS_AIR_TIMEOFDAY = 3203397129U;
        static const AkUniqueID SS_AIR_TURBULENCE = 4160247818U;
        static const AkUniqueID VAMPCOOLDOWN = 244091178U;
        static const AkUniqueID WINDINTENSITY = 1042517418U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID BOXDROPSTINGER = 556308635U;
        static const AkUniqueID BOXPICKUPSTINGER = 3525814506U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID BASE = 1291433366U;
        static const AkUniqueID BOX_AMBIENCE_BUS = 2758124570U;
        static const AkUniqueID BOX_HOLDING_BUS = 2190619839U;
        static const AkUniqueID DIEGETIC_SFX_BUS = 1073713956U;
        static const AkUniqueID FOOTSTEPS = 2385628198U;
        static const AkUniqueID HARPOON = 302949338U;
        static const AkUniqueID HARPOON_AMBIENCE_BUS = 286173556U;
        static const AkUniqueID HARPOONAIR = 1174992302U;
        static const AkUniqueID KICKSNARE_BUS = 831678660U;
        static const AkUniqueID LEFT_FOOTSTEP = 1014522048U;
        static const AkUniqueID MOTION_FACTORY_BUS = 985987111U;
        static const AkUniqueID MUSIC_BUS = 3127962312U;
        static const AkUniqueID RIGHT_FOOTSTEP = 854631381U;
        static const AkUniqueID TREE = 3322072369U;
        static const AkUniqueID TREE_WIND = 2466686001U;
        static const AkUniqueID VAMP_BUS = 3225388919U;
        static const AkUniqueID WIND = 1537061107U;
        static const AkUniqueID WORLDKEYS = 1310325127U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID DEFAULT_MOTION_DEVICE = 4230635974U;
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
