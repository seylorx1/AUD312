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
        static const AkUniqueID BOX_DROP = 4002303308U;
        static const AkUniqueID BOX_PICKUP = 2562895519U;
        static const AkUniqueID HARPOON_PICKUP = 1351179785U;
        static const AkUniqueID PROTO_MUSIC_DYNAMIC = 4238444291U;
        static const AkUniqueID PROTO_MUSIC_GENERIC = 2902858375U;
        static const AkUniqueID PROTO_SFX_FOOTSTEP_CARPET = 2674483148U;
        static const AkUniqueID PROTO_SFX_FOOTSTEP_FLOORBOARDS = 3944690194U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace BOXHELD
        {
            static const AkUniqueID GROUP = 2060468149U;

            namespace STATE
            {
                static const AkUniqueID BOX_ISHELD = 1843189762U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace BOXHELD

        namespace HARPOONHELD
        {
            static const AkUniqueID GROUP = 515864255U;

            namespace STATE
            {
                static const AkUniqueID HARPOON_ISHELD = 1182553944U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace HARPOONHELD

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
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MOTION_FACTORY_BUS = 985987111U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID DEFAULT_MOTION_DEVICE = 4230635974U;
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
