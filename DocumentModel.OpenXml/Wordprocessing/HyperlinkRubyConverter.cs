namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the HyperlinkRuby Class.
/// </summary>
public static class HyperlinkRubyConverter
{
  /// <summary>
  /// tgtFrame
  /// </summary>
  private static String? GetTargetFrame(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TargetFrame);
  }
  
  private static bool CmpTargetFrame(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TargetFrame, value, diffs, objName, "TargetFrame");
  }
  
  private static void SetTargetFrame(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.TargetFrame = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tooltip
  /// </summary>
  private static String? GetTooltip(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tooltip);
  }
  
  private static bool CmpTooltip(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tooltip, value, diffs, objName, "Tooltip");
  }
  
  private static void SetTooltip(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Tooltip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// docLocation
  /// </summary>
  private static String? GetDocLocation(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DocLocation);
  }
  
  private static bool CmpDocLocation(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DocLocation, value, diffs, objName, "DocLocation");
  }
  
  private static void SetDocLocation(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.DocLocation = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// history
  /// </summary>
  private static Boolean? GetHistory(DXW.HyperlinkRuby openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.History);
  }
  
  private static bool CmpHistory(DXW.HyperlinkRuby openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.History, value, diffs, objName, "History");
  }
  
  private static void SetHistory(DXW.HyperlinkRuby openXmlElement, Boolean? value)
  {
    openXmlElement.History = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// anchor
  /// </summary>
  private static String? GetAnchor(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Anchor);
  }
  
  private static bool CmpAnchor(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Anchor, value, diffs, objName, "Anchor");
  }
  
  private static void SetAnchor(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Anchor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMW.CustomXmlRuby? GetCustomXmlRuby(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlRuby>();
    if (element != null)
      return DMXW.CustomXmlRubyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlRuby(DXW.HyperlinkRuby openXmlElement, DMW.CustomXmlRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRuby>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlRuby(DXW.HyperlinkRuby openXmlElement, DMW.CustomXmlRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRubyConverter.CreateOpenXmlElement<DXW.CustomXmlRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SimpleFieldRuby? GetSimpleFieldRuby(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SimpleFieldRuby>();
    if (element != null)
      return DMXW.SimpleFieldRubyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSimpleFieldRuby(DXW.HyperlinkRuby openXmlElement, DMW.SimpleFieldRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.SimpleFieldRubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SimpleFieldRuby>(), value, diffs, objName);
  }
  
  private static void SetSimpleFieldRuby(DXW.HyperlinkRuby openXmlElement, DMW.SimpleFieldRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SimpleFieldRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SimpleFieldRubyConverter.CreateOpenXmlElement<DXW.SimpleFieldRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.HyperlinkRuby? GetChildHyperlinkRuby(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.HyperlinkRuby>();
    if (element != null)
      return DMXW.HyperlinkRubyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildHyperlinkRuby(DXW.HyperlinkRuby openXmlElement, DMW.HyperlinkRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkRubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.HyperlinkRuby>(), value, diffs, objName);
  }
  
  private static void SetChildHyperlinkRuby(DXW.HyperlinkRuby openXmlElement, DMW.HyperlinkRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HyperlinkRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkRubyConverter.CreateOpenXmlElement<DXW.HyperlinkRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Run? GetRun(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Run>();
    if (element != null)
      return DMXW.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXW.HyperlinkRuby openXmlElement, DMW.Run? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Run>(), value, diffs, objName);
  }
  
  private static void SetRun(DXW.HyperlinkRuby openXmlElement, DMW.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConverter.CreateOpenXmlElement<DXW.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRunRuby? GetSdtRunRuby(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRunRuby>();
    if (element != null)
      return DMXW.SdtRunRubyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtRunRuby(DXW.HyperlinkRuby openXmlElement, DMW.SdtRunRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunRubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRunRuby>(), value, diffs, objName);
  }
  
  private static void SetSdtRunRuby(DXW.HyperlinkRuby openXmlElement, DMW.SdtRunRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRunRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunRubyConverter.CreateOpenXmlElement<DXW.SdtRunRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (element != null)
      return DMXW.ProofErrorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProofError(DXW.HyperlinkRuby openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofError>(), value, diffs, objName);
  }
  
  private static void SetProofError(DXW.HyperlinkRuby openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (element != null)
      return DMXW.PermStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermStart(DXW.HyperlinkRuby openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermStart>(), value, diffs, objName);
  }
  
  private static void SetPermStart(DXW.HyperlinkRuby openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (element != null)
      return DMXW.PermEndConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermEnd(DXW.HyperlinkRuby openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermEnd>(), value, diffs, objName);
  }
  
  private static void SetPermEnd(DXW.HyperlinkRuby openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (element != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkStart(DXW.HyperlinkRuby openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName);
  }
  
  private static void SetBookmarkStart(DXW.HyperlinkRuby openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkEnd? GetBookmarkEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName);
  }
  
  private static void SetBookmarkEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CommentRangeStart? GetCommentRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCommentRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CommentRangeEnd? GetCommentRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCommentRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRangeStart? GetMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRangeEnd? GetMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRangeStart? GetMoveToRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName);
  }
  
  private static void SetMoveToRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRangeEnd? GetMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlInsRangeStart? GetCustomXmlInsRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlInsRangeEnd? GetCustomXmlInsRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlDelRangeStart? GetCustomXmlDelRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlDelRangeEnd? GetCustomXmlDelRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlMoveFromRangeStart? GetCustomXmlMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlMoveFromRangeEnd? GetCustomXmlMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlMoveToRangeStart? GetCustomXmlMoveToRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlMoveToRangeEnd? GetCustomXmlMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlConflictInsertionRangeStart? GetCustomXmlConflictInsertionRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlConflictInsertionRangeEnd? GetCustomXmlConflictInsertionRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlConflictDeletionRangeStart? GetCustomXmlConflictDeletionRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.HyperlinkRuby openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlConflictDeletionRangeEnd? GetCustomXmlConflictDeletionRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.HyperlinkRuby openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (element != null)
      return DMXW.InsertedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedRun(DXW.HyperlinkRuby openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName);
  }
  
  private static void SetInsertedRun(DXW.HyperlinkRuby openXmlElement, DMW.InsertedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedRun? GetDeletedRun(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (element != null)
      return DMXW.DeletedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedRun(DXW.HyperlinkRuby openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName);
  }
  
  private static void SetDeletedRun(DXW.HyperlinkRuby openXmlElement, DMW.DeletedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (element != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRun(DXW.HyperlinkRuby openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRun(DXW.HyperlinkRuby openXmlElement, DMW.MoveFromRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (element != null)
      return DMXW.MoveToRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRun(DXW.HyperlinkRuby openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName);
  }
  
  private static void SetMoveToRun(DXW.HyperlinkRuby openXmlElement, DMW.MoveToRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (element != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictInsertion(DXW.HyperlinkRuby openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetRunConflictInsertion(DXW.HyperlinkRuby openXmlElement, DMW.RunConflictInsertion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (element != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictDeletion(DXW.HyperlinkRuby openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetRunConflictDeletion(DXW.HyperlinkRuby openXmlElement, DMW.RunConflictDeletion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Paragraph? GetParagraph(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (element != null)
      return DMXMath.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXW.HyperlinkRuby openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName);
  }
  
  private static void SetParagraph(DXW.HyperlinkRuby openXmlElement, DMMath.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphConverter.CreateOpenXmlElement<DXMath.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (element != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMath(DXW.HyperlinkRuby openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName);
  }
  
  private static void SetOfficeMath(DXW.HyperlinkRuby openXmlElement, DMMath.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.OfficeMathConverter.CreateOpenXmlElement<DXMath.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Accent? GetAccent(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (element != null)
      return DMXMath.AccentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccent(DXW.HyperlinkRuby openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Accent>(), value, diffs, objName);
  }
  
  private static void SetAccent(DXW.HyperlinkRuby openXmlElement, DMMath.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentConverter.CreateOpenXmlElement<DXMath.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Bar? GetBar(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (element != null)
      return DMXMath.BarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar(DXW.HyperlinkRuby openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Bar>(), value, diffs, objName);
  }
  
  private static void SetBar(DXW.HyperlinkRuby openXmlElement, DMMath.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarConverter.CreateOpenXmlElement<DXMath.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Box? GetBox(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (element != null)
      return DMXMath.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXW.HyperlinkRuby openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Box>(), value, diffs, objName);
  }
  
  private static void SetBox(DXW.HyperlinkRuby openXmlElement, DMMath.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxConverter.CreateOpenXmlElement<DXMath.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BorderBox? GetBorderBox(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (element != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBox(DXW.HyperlinkRuby openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName);
  }
  
  private static void SetBorderBox(DXW.HyperlinkRuby openXmlElement, DMMath.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxConverter.CreateOpenXmlElement<DXMath.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Delimiter? GetDelimiter(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (element != null)
      return DMXMath.DelimiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiter(DXW.HyperlinkRuby openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName);
  }
  
  private static void SetDelimiter(DXW.HyperlinkRuby openXmlElement, DMMath.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterConverter.CreateOpenXmlElement<DXMath.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.EquationArray? GetEquationArray(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (element != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArray(DXW.HyperlinkRuby openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName);
  }
  
  private static void SetEquationArray(DXW.HyperlinkRuby openXmlElement, DMMath.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayConverter.CreateOpenXmlElement<DXMath.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Fraction? GetFraction(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (element != null)
      return DMXMath.FractionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFraction(DXW.HyperlinkRuby openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Fraction>(), value, diffs, objName);
  }
  
  private static void SetFraction(DXW.HyperlinkRuby openXmlElement, DMMath.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionConverter.CreateOpenXmlElement<DXMath.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.MathFunction? GetMathFunction(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (element != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathFunction(DXW.HyperlinkRuby openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName);
  }
  
  private static void SetMathFunction(DXW.HyperlinkRuby openXmlElement, DMMath.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathFunctionConverter.CreateOpenXmlElement<DXMath.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.GroupChar? GetGroupChar(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (element != null)
      return DMXMath.GroupCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupChar(DXW.HyperlinkRuby openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName);
  }
  
  private static void SetGroupChar(DXW.HyperlinkRuby openXmlElement, DMMath.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharConverter.CreateOpenXmlElement<DXMath.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLower? GetLimitLower(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (element != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLower(DXW.HyperlinkRuby openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName);
  }
  
  private static void SetLimitLower(DXW.HyperlinkRuby openXmlElement, DMMath.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerConverter.CreateOpenXmlElement<DXMath.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitUpper? GetLimitUpper(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (element != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpper(DXW.HyperlinkRuby openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName);
  }
  
  private static void SetLimitUpper(DXW.HyperlinkRuby openXmlElement, DMMath.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperConverter.CreateOpenXmlElement<DXMath.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Matrix? GetMatrix(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (element != null)
      return DMXMath.MatrixConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrix(DXW.HyperlinkRuby openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Matrix>(), value, diffs, objName);
  }
  
  private static void SetMatrix(DXW.HyperlinkRuby openXmlElement, DMMath.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixConverter.CreateOpenXmlElement<DXMath.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Nary? GetNary(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (element != null)
      return DMXMath.NaryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNary(DXW.HyperlinkRuby openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Nary>(), value, diffs, objName);
  }
  
  private static void SetNary(DXW.HyperlinkRuby openXmlElement, DMMath.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryConverter.CreateOpenXmlElement<DXMath.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Phantom? GetPhantom(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (element != null)
      return DMXMath.PhantomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantom(DXW.HyperlinkRuby openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Phantom>(), value, diffs, objName);
  }
  
  private static void SetPhantom(DXW.HyperlinkRuby openXmlElement, DMMath.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomConverter.CreateOpenXmlElement<DXMath.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Radical? GetRadical(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (element != null)
      return DMXMath.RadicalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadical(DXW.HyperlinkRuby openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Radical>(), value, diffs, objName);
  }
  
  private static void SetRadical(DXW.HyperlinkRuby openXmlElement, DMMath.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalConverter.CreateOpenXmlElement<DXMath.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (element != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuper(DXW.HyperlinkRuby openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName);
  }
  
  private static void SetPreSubSuper(DXW.HyperlinkRuby openXmlElement, DMMath.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperConverter.CreateOpenXmlElement<DXMath.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Subscript? GetSubscript(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (element != null)
      return DMXMath.SubscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscript(DXW.HyperlinkRuby openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Subscript>(), value, diffs, objName);
  }
  
  private static void SetSubscript(DXW.HyperlinkRuby openXmlElement, DMMath.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptConverter.CreateOpenXmlElement<DXMath.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (element != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscript(DXW.HyperlinkRuby openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName);
  }
  
  private static void SetSubSuperscript(DXW.HyperlinkRuby openXmlElement, DMMath.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptConverter.CreateOpenXmlElement<DXMath.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Superscript? GetSuperscript(DXW.HyperlinkRuby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (element != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscript(DXW.HyperlinkRuby openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Superscript>(), value, diffs, objName);
  }
  
  private static void SetSuperscript(DXW.HyperlinkRuby openXmlElement, DMMath.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptConverter.CreateOpenXmlElement<DXMath.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.HyperlinkRuby? CreateModelElement(DXW.HyperlinkRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.HyperlinkRuby();
      value.TargetFrame = GetTargetFrame(openXmlElement);
      value.Tooltip = GetTooltip(openXmlElement);
      value.DocLocation = GetDocLocation(openXmlElement);
      value.History = GetHistory(openXmlElement);
      value.Anchor = GetAnchor(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.CustomXmlRuby = GetCustomXmlRuby(openXmlElement);
      value.SimpleFieldRuby = GetSimpleFieldRuby(openXmlElement);
      value.ChildHyperlinkRuby = GetChildHyperlinkRuby(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.SdtRunRuby = GetSdtRunRuby(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
      value.BookmarkStart = GetBookmarkStart(openXmlElement);
      value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      value.MoveFromRangeStart = GetMoveFromRangeStart(openXmlElement);
      value.MoveFromRangeEnd = GetMoveFromRangeEnd(openXmlElement);
      value.MoveToRangeStart = GetMoveToRangeStart(openXmlElement);
      value.MoveToRangeEnd = GetMoveToRangeEnd(openXmlElement);
      value.CustomXmlInsRangeStart = GetCustomXmlInsRangeStart(openXmlElement);
      value.CustomXmlInsRangeEnd = GetCustomXmlInsRangeEnd(openXmlElement);
      value.CustomXmlDelRangeStart = GetCustomXmlDelRangeStart(openXmlElement);
      value.CustomXmlDelRangeEnd = GetCustomXmlDelRangeEnd(openXmlElement);
      value.CustomXmlMoveFromRangeStart = GetCustomXmlMoveFromRangeStart(openXmlElement);
      value.CustomXmlMoveFromRangeEnd = GetCustomXmlMoveFromRangeEnd(openXmlElement);
      value.CustomXmlMoveToRangeStart = GetCustomXmlMoveToRangeStart(openXmlElement);
      value.CustomXmlMoveToRangeEnd = GetCustomXmlMoveToRangeEnd(openXmlElement);
      value.CustomXmlConflictInsertionRangeStart = GetCustomXmlConflictInsertionRangeStart(openXmlElement);
      value.CustomXmlConflictInsertionRangeEnd = GetCustomXmlConflictInsertionRangeEnd(openXmlElement);
      value.CustomXmlConflictDeletionRangeStart = GetCustomXmlConflictDeletionRangeStart(openXmlElement);
      value.CustomXmlConflictDeletionRangeEnd = GetCustomXmlConflictDeletionRangeEnd(openXmlElement);
      value.InsertedRun = GetInsertedRun(openXmlElement);
      value.DeletedRun = GetDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Accent = GetAccent(openXmlElement);
      value.Bar = GetBar(openXmlElement);
      value.Box = GetBox(openXmlElement);
      value.BorderBox = GetBorderBox(openXmlElement);
      value.Delimiter = GetDelimiter(openXmlElement);
      value.EquationArray = GetEquationArray(openXmlElement);
      value.Fraction = GetFraction(openXmlElement);
      value.MathFunction = GetMathFunction(openXmlElement);
      value.GroupChar = GetGroupChar(openXmlElement);
      value.LimitLower = GetLimitLower(openXmlElement);
      value.LimitUpper = GetLimitUpper(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      value.Nary = GetNary(openXmlElement);
      value.Phantom = GetPhantom(openXmlElement);
      value.Radical = GetRadical(openXmlElement);
      value.PreSubSuper = GetPreSubSuper(openXmlElement);
      value.Subscript = GetSubscript(openXmlElement);
      value.SubSuperscript = GetSubSuperscript(openXmlElement);
      value.Superscript = GetSuperscript(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.HyperlinkRuby? openXmlElement, DMW.HyperlinkRuby? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTargetFrame(openXmlElement, value.TargetFrame, diffs, objName))
        ok = false;
      if (!CmpTooltip(openXmlElement, value.Tooltip, diffs, objName))
        ok = false;
      if (!CmpDocLocation(openXmlElement, value.DocLocation, diffs, objName))
        ok = false;
      if (!CmpHistory(openXmlElement, value.History, diffs, objName))
        ok = false;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpCustomXmlRuby(openXmlElement, value.CustomXmlRuby, diffs, objName))
        ok = false;
      if (!CmpSimpleFieldRuby(openXmlElement, value.SimpleFieldRuby, diffs, objName))
        ok = false;
      if (!CmpChildHyperlinkRuby(openXmlElement, value.ChildHyperlinkRuby, diffs, objName))
        ok = false;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpSdtRunRuby(openXmlElement, value.SdtRunRuby, diffs, objName))
        ok = false;
      if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
        ok = false;
      if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
        ok = false;
      if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
        ok = false;
      if (!CmpBookmarkStart(openXmlElement, value.BookmarkStart, diffs, objName))
        ok = false;
      if (!CmpBookmarkEnd(openXmlElement, value.BookmarkEnd, diffs, objName))
        ok = false;
      if (!CmpCommentRangeStart(openXmlElement, value.CommentRangeStart, diffs, objName))
        ok = false;
      if (!CmpCommentRangeEnd(openXmlElement, value.CommentRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeStart(openXmlElement, value.MoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeEnd(openXmlElement, value.MoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeStart(openXmlElement, value.MoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeEnd(openXmlElement, value.MoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeStart(openXmlElement, value.CustomXmlInsRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeEnd(openXmlElement, value.CustomXmlInsRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeStart(openXmlElement, value.CustomXmlDelRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeEnd(openXmlElement, value.CustomXmlDelRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeStart(openXmlElement, value.CustomXmlMoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeEnd(openXmlElement, value.CustomXmlMoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeStart(openXmlElement, value.CustomXmlMoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeEnd(openXmlElement, value.CustomXmlMoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeStart(openXmlElement, value.CustomXmlConflictInsertionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeEnd(openXmlElement, value.CustomXmlConflictInsertionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeStart(openXmlElement, value.CustomXmlConflictDeletionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeEnd(openXmlElement, value.CustomXmlConflictDeletionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpInsertedRun(openXmlElement, value.InsertedRun, diffs, objName))
        ok = false;
      if (!CmpDeletedRun(openXmlElement, value.DeletedRun, diffs, objName))
        ok = false;
      if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
        ok = false;
      if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
        ok = false;
      if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      if (!CmpAccent(openXmlElement, value.Accent, diffs, objName))
        ok = false;
      if (!CmpBar(openXmlElement, value.Bar, diffs, objName))
        ok = false;
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpBorderBox(openXmlElement, value.BorderBox, diffs, objName))
        ok = false;
      if (!CmpDelimiter(openXmlElement, value.Delimiter, diffs, objName))
        ok = false;
      if (!CmpEquationArray(openXmlElement, value.EquationArray, diffs, objName))
        ok = false;
      if (!CmpFraction(openXmlElement, value.Fraction, diffs, objName))
        ok = false;
      if (!CmpMathFunction(openXmlElement, value.MathFunction, diffs, objName))
        ok = false;
      if (!CmpGroupChar(openXmlElement, value.GroupChar, diffs, objName))
        ok = false;
      if (!CmpLimitLower(openXmlElement, value.LimitLower, diffs, objName))
        ok = false;
      if (!CmpLimitUpper(openXmlElement, value.LimitUpper, diffs, objName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
        ok = false;
      if (!CmpNary(openXmlElement, value.Nary, diffs, objName))
        ok = false;
      if (!CmpPhantom(openXmlElement, value.Phantom, diffs, objName))
        ok = false;
      if (!CmpRadical(openXmlElement, value.Radical, diffs, objName))
        ok = false;
      if (!CmpPreSubSuper(openXmlElement, value.PreSubSuper, diffs, objName))
        ok = false;
      if (!CmpSubscript(openXmlElement, value.Subscript, diffs, objName))
        ok = false;
      if (!CmpSubSuperscript(openXmlElement, value.SubSuperscript, diffs, objName))
        ok = false;
      if (!CmpSuperscript(openXmlElement, value.Superscript, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.HyperlinkRuby value)
    where OpenXmlElementType: DXW.HyperlinkRuby, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.HyperlinkRuby openXmlElement, DMW.HyperlinkRuby value)
  {
    SetTargetFrame(openXmlElement, value?.TargetFrame);
    SetTooltip(openXmlElement, value?.Tooltip);
    SetDocLocation(openXmlElement, value?.DocLocation);
    SetHistory(openXmlElement, value?.History);
    SetAnchor(openXmlElement, value?.Anchor);
    SetId(openXmlElement, value?.Id);
    SetCustomXmlRuby(openXmlElement, value?.CustomXmlRuby);
    SetSimpleFieldRuby(openXmlElement, value?.SimpleFieldRuby);
    SetChildHyperlinkRuby(openXmlElement, value?.ChildHyperlinkRuby);
    SetRun(openXmlElement, value?.Run);
    SetSdtRunRuby(openXmlElement, value?.SdtRunRuby);
    SetProofError(openXmlElement, value?.ProofError);
    SetPermStart(openXmlElement, value?.PermStart);
    SetPermEnd(openXmlElement, value?.PermEnd);
    SetBookmarkStart(openXmlElement, value?.BookmarkStart);
    SetBookmarkEnd(openXmlElement, value?.BookmarkEnd);
    SetCommentRangeStart(openXmlElement, value?.CommentRangeStart);
    SetCommentRangeEnd(openXmlElement, value?.CommentRangeEnd);
    SetMoveFromRangeStart(openXmlElement, value?.MoveFromRangeStart);
    SetMoveFromRangeEnd(openXmlElement, value?.MoveFromRangeEnd);
    SetMoveToRangeStart(openXmlElement, value?.MoveToRangeStart);
    SetMoveToRangeEnd(openXmlElement, value?.MoveToRangeEnd);
    SetCustomXmlInsRangeStart(openXmlElement, value?.CustomXmlInsRangeStart);
    SetCustomXmlInsRangeEnd(openXmlElement, value?.CustomXmlInsRangeEnd);
    SetCustomXmlDelRangeStart(openXmlElement, value?.CustomXmlDelRangeStart);
    SetCustomXmlDelRangeEnd(openXmlElement, value?.CustomXmlDelRangeEnd);
    SetCustomXmlMoveFromRangeStart(openXmlElement, value?.CustomXmlMoveFromRangeStart);
    SetCustomXmlMoveFromRangeEnd(openXmlElement, value?.CustomXmlMoveFromRangeEnd);
    SetCustomXmlMoveToRangeStart(openXmlElement, value?.CustomXmlMoveToRangeStart);
    SetCustomXmlMoveToRangeEnd(openXmlElement, value?.CustomXmlMoveToRangeEnd);
    SetCustomXmlConflictInsertionRangeStart(openXmlElement, value?.CustomXmlConflictInsertionRangeStart);
    SetCustomXmlConflictInsertionRangeEnd(openXmlElement, value?.CustomXmlConflictInsertionRangeEnd);
    SetCustomXmlConflictDeletionRangeStart(openXmlElement, value?.CustomXmlConflictDeletionRangeStart);
    SetCustomXmlConflictDeletionRangeEnd(openXmlElement, value?.CustomXmlConflictDeletionRangeEnd);
    SetInsertedRun(openXmlElement, value?.InsertedRun);
    SetDeletedRun(openXmlElement, value?.DeletedRun);
    SetMoveFromRun(openXmlElement, value?.MoveFromRun);
    SetMoveToRun(openXmlElement, value?.MoveToRun);
    SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
    SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
    SetParagraph(openXmlElement, value?.Paragraph);
    SetOfficeMath(openXmlElement, value?.OfficeMath);
    SetAccent(openXmlElement, value?.Accent);
    SetBar(openXmlElement, value?.Bar);
    SetBox(openXmlElement, value?.Box);
    SetBorderBox(openXmlElement, value?.BorderBox);
    SetDelimiter(openXmlElement, value?.Delimiter);
    SetEquationArray(openXmlElement, value?.EquationArray);
    SetFraction(openXmlElement, value?.Fraction);
    SetMathFunction(openXmlElement, value?.MathFunction);
    SetGroupChar(openXmlElement, value?.GroupChar);
    SetLimitLower(openXmlElement, value?.LimitLower);
    SetLimitUpper(openXmlElement, value?.LimitUpper);
    SetMatrix(openXmlElement, value?.Matrix);
    SetNary(openXmlElement, value?.Nary);
    SetPhantom(openXmlElement, value?.Phantom);
    SetRadical(openXmlElement, value?.Radical);
    SetPreSubSuper(openXmlElement, value?.PreSubSuper);
    SetSubscript(openXmlElement, value?.Subscript);
    SetSubSuperscript(openXmlElement, value?.SubSuperscript);
    SetSuperscript(openXmlElement, value?.Superscript);
  }
}
