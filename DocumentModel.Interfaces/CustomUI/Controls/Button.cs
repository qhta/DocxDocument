using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a button control that executes an action when clicked in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// Features:
/// <list type="bullet">
/// <item>Represents a standard button control for the Office Ribbon.</item>
/// <item>Used in a wide range of ribbon locations, including tabs, groups, and toolbars.</item>
/// <item>Supports a broader set of features, including different sizing options and placement flexibility.</item>
/// </list>
/// </remarks>
public interface Button : CustomUIControl, BuiltInObject, TaggedObject, 
  DescriptionControl, SizeControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  BoxContent, GroupContent
{
}