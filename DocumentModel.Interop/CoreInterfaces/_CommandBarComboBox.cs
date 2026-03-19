using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C030C-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface _CommandBarComboBox: CommandBarControl
{
  [DispId(-5000)]
  new object accParent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5000)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5001)]
  new int accChildCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5001)]
    [TypeLibFunc(1088)]
    get;
  }

  [DispId(-5002)]
  new object accChild
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5002)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5003)]
  new string accName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5003)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5003)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(-5004)]
  new string accValue
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5004)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5004)]
    [TypeLibFunc(1088)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(-5005)]
  new string accDescription
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5005)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5006)]
  new object accRole
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5006)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5007)]
  new object accState
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5007)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5008)]
  new string accHelp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5008)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5009)]
  new int accHelpTopic
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5009)]
    get;
  }

  [DispId(-5010)]
  new string accKeyboardShortcut
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5010)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5011)]
  new object accFocus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5011)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5012)]
  new object accSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5012)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5013)]
  new string accDefaultAction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5013)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5014)]
  [TypeLibFunc(1088)]
  new void accSelect([In] int flagsSelect, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5015)]
  new void accLocation
  (out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5016)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accNavigate([In] int navDir, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varStart);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5017)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accHitTest([In] int xLeft, [In] int yTop);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5018)]
  new void accDoDefaultAction([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [DispId(1610809344)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809345)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    get;
  }

  [DispId(1610874880)]
  new bool BeginGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874880)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874880)]
    [param: In]
    set;
  }

  [DispId(1610874882)]
  new bool BuiltIn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874882)]
    get;
  }

  [DispId(1610874883)]
  new string Caption
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874883)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874883)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874885)]
  new object Control
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610874885)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874886)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new CommandBarControl Copy
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Bar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874887)]
  new void Delete([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Temporary);

  [DispId(1610874888)]
  new string DescriptionText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874888)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874888)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874890)]
  new bool Enabled
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874890)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874890)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874892)]
  new void Execute();

  [DispId(1610874893)]
  new int Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874893)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874893)]
    [param: In]
    set;
  }

  [DispId(1610874895)]
  new int HelpContextId
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874895)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874895)]
    [param: In]
    set;
  }

  [DispId(1610874897)]
  new string HelpFile
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874897)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874897)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874899)]
  new int Id
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874899)]
    get;
  }

  [DispId(1610874900)]
  new int Index
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874900)]
    get;
  }

  [DispId(1610874901)]
  new int InstanceId
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874901)]
    [TypeLibFunc(64)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874902)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new CommandBarControl Move
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Bar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before);

  [DispId(1610874903)]
  new int Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874903)]
    get;
  }

  [DispId(1610874904)]
  new MsoControlOLEUsage OLEUsage
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874904)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874904)]
    [param: In]
    set;
  }

  [DispId(1610874906)]
  new string OnAction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874906)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874906)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874908)]
  new CommandBar Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874908)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610874909)]
  new string Parameter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874909)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874909)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874911)]
  new int Priority
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874911)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874911)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874913)]
  new void Reset();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874914)]
  new void SetFocus();

  [DispId(1610874915)]
  new string Tag
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874915)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874915)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874917)]
  new string TooltipText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874917)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874917)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874919)]
  new int Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874919)]
    get;
  }

  [DispId(1610874920)]
  new MsoControlType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874920)]
    get;
  }

  [DispId(1610874921)]
  new bool Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874921)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874921)]
    [param: In]
    set;
  }

  [DispId(1610874923)]
  new int Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874923)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874923)]
    [param: In]
    set;
  }

  [DispId(1610874925)]
  new bool IsPriorityDropped
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874925)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(1610874926)]
  new void Reserved1();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(1610874927)]
  new void Reserved2();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874928)]
  [TypeLibFunc(64)]
  new void Reserved3();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874929)]
  [TypeLibFunc(64)]
  new void Reserved4();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874930)]
  [TypeLibFunc(64)]
  new void Reserved5();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(1610874931)]
  new void Reserved6();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874932)]
  [TypeLibFunc(64)]
  new void Reserved7();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610940416)]
  void AddItem
    ([In] [MarshalAs(UnmanagedType.BStr)] string Text, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610940417)]
  void Clear();

  [DispId(1610940418)]
  int DropDownLines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940418)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940418)]
    [param: In]
    set;
  }

  [DispId(1610940420)]
  int DropDownWidth
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940420)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940420)]
    [param: In]
    set;
  }

  [DispId(1610940422)]
  string List
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940422)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940422)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610940424)]
  int ListCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940424)]
    get;
  }

  [DispId(1610940425)]
  int ListHeaderCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940425)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940425)]
    [param: In]
    set;
  }

  [DispId(1610940427)]
  int ListIndex
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940427)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940427)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610940429)]
  void RemoveItem([In] int Index);

  [DispId(1610940430)]
  MsoComboStyle Style
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940430)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940430)]
    [param: In]
    set;
  }

  [DispId(1610940432)]
  string Text
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940432)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940432)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610940434)]
  object InstanceIdPtr
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610940434)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }
}