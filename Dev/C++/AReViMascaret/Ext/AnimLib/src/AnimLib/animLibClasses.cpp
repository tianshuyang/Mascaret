
/****
This file is generated by the register-classes script
Do not edit or your changes will be lost !
****/

namespace AnimLib {

class ArKeyFrameTrack { public: static void REGISTER_CLASS(void); };
class ArTrackPosition { public: static void REGISTER_CLASS(void); };
class ArTrackOrientation { public: static void REGISTER_CLASS(void); };
class ArTrackBase3D { public: static void REGISTER_CLASS(void); };
class ArTrackTranslation { public: static void REGISTER_CLASS(void); };
class ArTrackRotation { public: static void REGISTER_CLASS(void); };
class ArTrackSpiral { public: static void REGISTER_CLASS(void); };
class ArTrackMaterial3D { public: static void REGISTER_CLASS(void); };
class ArTrackTexture { public: static void REGISTER_CLASS(void); };
class ArTrackScale { public: static void REGISTER_CLASS(void); };

void
registerAnimLibClasses(void)
{
ArKeyFrameTrack::REGISTER_CLASS();
ArTrackPosition::REGISTER_CLASS();
ArTrackOrientation::REGISTER_CLASS();
ArTrackBase3D::REGISTER_CLASS();
ArTrackTranslation::REGISTER_CLASS();
ArTrackRotation::REGISTER_CLASS();
ArTrackSpiral::REGISTER_CLASS();
ArTrackMaterial3D::REGISTER_CLASS();
ArTrackTexture::REGISTER_CLASS();
ArTrackScale::REGISTER_CLASS();
}

} // namespace AnimLib

