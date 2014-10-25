/* AReViSignalWidget.h --- 
 * 
 * Filename: AReViSignalWidget.h
 * Description: Create a widget which list operations of the current clicked entity
 * Author: Julien Rolland
 * Maintainer: 
 * Created: lun. nov. 21 22:23:46 2011 (+0100)
 * Version: 
 * Last-Updated: 
 *           By: 
 *     Update #: 0
 * URL: 
 * Keywords: 
 * Compatibility: 
 * 
 */

/* Commentary: 
 * 
 * 
 * 
 */

/* Change Log:
 * 
 * 
 */

/* Code: */

#ifndef AREVISIGNALWIDGET_H_
#define AREVISIGNALWIDGET_H_ 

#include "AReVi/arObject.h"
#if 0
#include "ArWidget/aw_plateform.h"
#endif

#include "areviMascaret_plateform.h"
#include "AReVi/Lib3D/simpleInteractor.h"
#include "AReVi/Lib3D/viewer3D.h"
#include "Interaction/AReViMouse.h"

#include "ArWidget/utils.h"
#include "ArWidget/awButton.h"

#include "VEHA/Entity/Entity.h"
#include "VEHA/Kernel/Environment.h"
#include "VEHA/Kernel/Property.h"
#include "VEHA/Behavior/Common/BehaviorExecution.h"
#include "VRPlateform/AReViWindow3D.h"
//#include "VRPlateform/AReViTutor.h"

//namespace AReVi
//{
    class AwRadioGroup;
    class AwEntry;
//}

//using AReVi::AwRadioGroup;
//using AReVi::AwEntry;

using namespace VEHA;
using namespace IEHA;

namespace AReViMascaret
{
  class AREVI_MASCARET_API AReViSignalWidget : public ArObject
  {
  public:
    AR_CLASS(AReViSignalWidget);
    AR_CONSTRUCTOR_1(AReViSignalWidget,AReViWindow3D*,_viewer);

    inline void setEntity(shared_ptr<Entity> entity) { _entity = entity; }
    inline shared_ptr<Entity> getEntity() { return _entity; }
    inline ArRef<Viewer3D> getViewer() { return _viewer; }
    // inline ArRef<AReViMouse> getMouse() { return _mouse; }
    inline void setMouse(shared_ptr<AReViMouse> mouse) { _mouse = mouse; }
    inline void setEnvironment(shared_ptr<Environment> environment) { _environment = environment; }
    void show();

  protected:
    void _findEntities(string type, ArRef<AwRadioGroup> group, ArRef<AwLabel> labelParam);
    shared_ptr<Entity> _findEntityInGroup(ArRef<AwRadioGroup> group, vector<shared_ptr<Entity> > entities);

    void _focus(bool focus);
    void _parse();
    void _clear();

    void _getSignals();

    void _onCancelButtonClick(const AwButton::ClickEvent &evt);
    void _onCancelParaButtonClick(const AwButton::ClickEvent &evt);
    void _onSignalButtonClick(const AwButton::ClickEvent &evt);
    void _onButtonParameterClick(const AwButton::ClickEvent &evt);
    void _onExecuteButtonClick(const AwButton::ClickEvent &evt);

  protected:
    ArRef<Viewer3D> _viewer;
    AReViWindow3D* _window3D;
//    shared_ptr<Tutor> _tutor;
    shared_ptr<AReViMouse> _mouse;
    ArRef<SimpleInteractor> _interactor;
    ArRef<WidgetInteractor> _widgetInteractor;
    shared_ptr<Entity> _entity;
    shared_ptr<Environment> _environment;

    ArRef<AReVi::XmlParser> _parser;
    ArRef<AwButton> _cancelButton;
    ArRef<AwButton> _cancelParaButton;
    ArRef<AwButton> _executeButton;
    ArRef<AwWidget> _window;
    ArRef<AwWidget> _parametersWindow;
    ArRef<AwArray> _signalsArray;
    ArRef<AwArray> _parametersArray;
    ArRef<AwLabel> _classLabel;
    ArRef<AwLabel> _classLabelPara;

    map<string, ArRef<AwEntry> > _primitiveParameters;
    std::multimap<ArRef<AwRadioGroup>, vector<shared_ptr<Entity> > > _entitiesParameters;
    std::multimap<ArRef<AwRadioGroup>, string > _entitiesParametersName;
    map<string, shared_ptr<Property> > _properties;

    
    StlMap<StlString, ArRef<AwWidget> > _widgets;
    map<string, shared_ptr<Signal> > _sigs;
    shared_ptr<Signal> _currentSignal;
  };
}

#endif /* AReViSignalWidget.h ends here */
