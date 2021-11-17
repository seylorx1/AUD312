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
        static const AkUniqueID BOXDROP = 3810078911U;
        static const AkUniqueID BOXPICKUP = 2671589300U;
        static const AkUniqueID FOOTSTEPCHANGE_CONCRETE = 963962511U;
        static const AkUniqueID FOOTSTEPCHANGE_GRAVEL = 1670615683U;
        static const AkUniqueID FOOTSTEPPLAY = 4039405217U;
        static const AkUniqueID HARPOONGRABSUCCESS = 2837856117U;
        static const AkUniqueID HARPOONLOOPSTART = 1976912264U;
        static const AkUniqueID HARPOONLOOPSTOP = 1264241620U;
        static const AkUniqueID HARPOONPICKUP = 2867011390U;
        static const AkUniqueID ITEMDROP = 3684409175U;
        static const AkUniqueID ITEMPICKUP = 1851462748U;
        static const AkUniqueID MUSIC_BOAT = 1325856759U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace HARPOONHELD
        {
            static const AkUniqueID GROUP = 515864255U;

            namespace STATE
            {
                static const AkUniqueID HARPOON_ISHELD = 1182553944U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace HARPOONHELD

        namespace ITEMHELD
        {
            static const AkUniqueID GROUP = 2782314781U;

            namespace STATE
            {
                static const AkUniqueID ITEM_ISHELD = 1159598586U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace ITEMHELD

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

        namespace ROOM_CORRIDOR
        {
            static const AkUniqueID GROUP = 2968376717U;

            namespace STATE
            {
                static const AkUniqueID ENTERED = 2066668302U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace ROOM_CORRIDOR

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPTYPE
        {
            static const AkUniqueID GROUP = 1458816175U;

            namespace SWITCH
            {
                static const AkUniqueID CONCRETE = 841620460U;
                static const AkUniqueID GRAVEL = 2185786256U;
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
        static const AkUniqueID BACKUP_MUSIC = 1323876822U;
        static const AkUniqueID MOTION_FACTORY_BUS = 985987111U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID MUSIC_BUS = 3127962312U;
        static const AkUniqueID SOUND_EFFECTS_BUS = 57144414U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID DEFAULT_MOTION_DEVICE = 4230635974U;
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
