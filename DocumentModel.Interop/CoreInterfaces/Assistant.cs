using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[DefaultMember("Item")]
[Guid("000C0322-0000-0000-C000-000000000046")]
public interface Assistant: _IMsoDispObj
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [DispId(1610809344)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809345)]
  void Move([In] int xLeft, [In] int yTop);

  [DispId(1610809346)]
  int Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809346)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809346)]
    [param: In]
    set;
  }

  [DispId(1610809348)]
  int Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809350)]
  void Help();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809351)]
  int StartWizard
  ([In] bool On, [In] [MarshalAs(UnmanagedType.BStr)] string Callback, [In] int PrivateX,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Animation,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomTeaser,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Bottom,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Right);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809352)]
  void EndWizard
    ([In] int WizardID, [In] bool varfSuccess, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Animation);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809353)]
  void ActivateWizard
    ([In] int WizardID, [In] MsoWizardActType act, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Animation);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809354)]
  void ResetTips();

  [DispId(1610809355)]
  Balloon NewBalloon
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809355)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809356)]
  MsoBalloonErrorType BalloonError
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809356)]
    get;
  }

  [DispId(1610809357)]
  bool Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809357)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809357)]
    [param: In]
    set;
  }

  [DispId(1610809359)]
  MsoAnimationType Animation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    [param: In]
    set;
  }

  [DispId(1610809361)]
  bool Reduced
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809361)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809361)]
    [param: In]
    set;
  }

  [DispId(1610809363)]
  bool AssistWithHelp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809363)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809363)]
    [param: In]
    set;
  }

  [DispId(1610809365)]
  bool AssistWithWizards
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809365)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809365)]
    [param: In]
    set;
  }

  [DispId(1610809367)]
  bool AssistWithAlerts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809367)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809367)]
    [param: In]
    set;
  }

  [DispId(1610809369)]
  bool MoveWhenInTheWay
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809369)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809369)]
    [param: In]
    set;
  }

  [DispId(1610809371)]
  bool Sounds
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809371)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809371)]
    [param: In]
    set;
  }

  [DispId(1610809373)]
  bool FeatureTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809373)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809373)]
    [param: In]
    set;
  }

  [DispId(1610809375)]
  bool MouseTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809375)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809375)]
    [param: In]
    set;
  }

  [DispId(1610809377)]
  bool KeyboardShortcutTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809377)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809377)]
    [param: In]
    set;
  }

  [DispId(1610809379)]
  bool HighPriorityTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809379)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809379)]
    [param: In]
    set;
  }

  [DispId(1610809381)]
  bool TipOfDay
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809381)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809381)]
    [param: In]
    set;
  }

  [DispId(1610809383)]
  bool GuessHelp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809383)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809383)]
    [param: In]
    set;
  }

  [DispId(1610809385)]
  bool SearchWhenProgramming
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809385)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809385)]
    [param: In]
    set;
  }

  [DispId(0)]
  string Item
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809388)]
  string FileName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809388)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809388)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610809390)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809390)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809391)]
  bool On
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809391)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809391)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809393)]
  int DoAlert
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrAlertTitle,
    [In] [MarshalAs(UnmanagedType.BStr)] string bstrAlertText, [In] MsoAlertButtonType alb, [In] MsoAlertIconType alc,
    [In] MsoAlertDefaultType ald, [In] MsoAlertCancelType alq, [In] bool varfSysAlert);
}