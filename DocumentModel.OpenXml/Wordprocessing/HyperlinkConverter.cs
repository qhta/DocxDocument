namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Hyperlink Class.
/// </summary>
public static class HyperlinkConverter
{
  /// <summary>
  /// Hyperlink Target Frame
  /// </summary>
  private static String? GetTargetFrame(DXW.Hyperlink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TargetFrame);
  }
  
  private static bool CmpTargetFrame(DXW.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TargetFrame, value, diffs, objName, "TargetFrame");
  }
  
  private static void SetTargetFrame(DXW.Hyperlink openXmlElement, String? value)
  {
    openXmlElement.TargetFrame = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Associated String
  /// </summary>
  private static String? GetTooltip(DXW.Hyperlink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tooltip);
  }
  
  private static bool CmpTooltip(DXW.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tooltip, value, diffs, objName, "Tooltip");
  }
  
  private static void SetTooltip(DXW.Hyperlink openXmlElement, String? value)
  {
    openXmlElement.Tooltip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Location in Target Document
  /// </summary>
  private static String? GetDocLocation(DXW.Hyperlink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DocLocation);
  }
  
  private static bool CmpDocLocation(DXW.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DocLocation, value, diffs, objName, "DocLocation");
  }
  
  private static void SetDocLocation(DXW.Hyperlink openXmlElement, String? value)
  {
    openXmlElement.DocLocation = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Add To Viewed Hyperlinks
  /// </summary>
  private static Boolean? GetHistory(DXW.Hyperlink openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.History);
  }
  
  private static bool CmpHistory(DXW.Hyperlink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.History, value, diffs, objName, "History");
  }
  
  private static void SetHistory(DXW.Hyperlink openXmlElement, Boolean? value)
  {
    openXmlElement.History = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Hyperlink Anchor
  /// </summary>
  private static String? GetAnchor(DXW.Hyperlink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Anchor);
  }
  
  private static bool CmpAnchor(DXW.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Anchor, value, diffs, objName, "Anchor");
  }
  
  private static void SetAnchor(DXW.Hyperlink openXmlElement, String? value)
  {
    openXmlElement.Anchor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetId(DXW.Hyperlink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.Hyperlink openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMW.CustomXmlRun? GetCustomXmlRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlRun>();
    if (element != null)
      return DMXW.CustomXmlRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlRun(DXW.Hyperlink openXmlElement, DMW.CustomXmlRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlRun(DXW.Hyperlink openXmlElement, DMW.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRunConverter.CreateOpenXmlElement<DXW.CustomXmlRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.SimpleField>? GetSimpleFields(DXW.Hyperlink openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSimpleFields(DXW.Hyperlink openXmlElement, Collection<DMW.SimpleField>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.SimpleField>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.SimpleFieldConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSimpleFields(DXW.Hyperlink openXmlElement, Collection<DMW.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.SimpleFieldConverter.CreateOpenXmlElement<DXW.SimpleField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Hyperlink? GetChildHyperlink(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Hyperlink>();
    if (element != null)
      return DMXW.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildHyperlink(DXW.Hyperlink openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Hyperlink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildHyperlink(DXW.Hyperlink openXmlElement, DMW.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkConverter.CreateOpenXmlElement<DXW.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRun? GetSdtRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (element != null)
      return DMXW.SdtRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtRun(DXW.Hyperlink openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtRun(DXW.Hyperlink openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement<DXW.SdtRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (element != null)
      return DMXW.ProofErrorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProofError(DXW.Hyperlink openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofError>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProofError(DXW.Hyperlink openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement<DXW.ProofError>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (element != null)
      return DMXW.PermStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermStart(DXW.Hyperlink openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermStart(DXW.Hyperlink openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement<DXW.PermStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (element != null)
      return DMXW.PermEndConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermEnd(DXW.Hyperlink openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermEnd(DXW.Hyperlink openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement<DXW.PermEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (element != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkStart(DXW.Hyperlink openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXW.Hyperlink openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement<DXW.BookmarkStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeStart(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeStart(DXW.Hyperlink openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXW.Hyperlink openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeStart(DXW.Hyperlink openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXW.Hyperlink openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.Hyperlink openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.Hyperlink openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (element != null)
      return DMXW.InsertedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedRun(DXW.Hyperlink openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsertedRun(DXW.Hyperlink openXmlElement, DMW.InsertedRun? value)
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
  
  private static DMW.DeletedRun? GetDeletedRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (element != null)
      return DMXW.DeletedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedRun(DXW.Hyperlink openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedRun(DXW.Hyperlink openXmlElement, DMW.DeletedRun? value)
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
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (element != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRun(DXW.Hyperlink openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRun(DXW.Hyperlink openXmlElement, DMW.MoveFromRun? value)
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
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (element != null)
      return DMXW.MoveToRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRun(DXW.Hyperlink openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRun(DXW.Hyperlink openXmlElement, DMW.MoveToRun? value)
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
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (element != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictInsertion(DXW.Hyperlink openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictInsertion(DXW.Hyperlink openXmlElement, DMW.RunConflictInsertion? value)
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
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (element != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictDeletion(DXW.Hyperlink openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictDeletion(DXW.Hyperlink openXmlElement, DMW.RunConflictDeletion? value)
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
  
  private static DMMath.Paragraph? GetParagraph(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (element != null)
      return DMXMath.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXW.Hyperlink openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraph(DXW.Hyperlink openXmlElement, DMMath.Paragraph? value)
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
  
  private static DMMath.OfficeMath? GetOfficeMath(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (element != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMath(DXW.Hyperlink openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeMath(DXW.Hyperlink openXmlElement, DMMath.OfficeMath? value)
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
  
  private static DMMath.Accent? GetAccent(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (element != null)
      return DMXMath.AccentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccent(DXW.Hyperlink openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Accent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAccent(DXW.Hyperlink openXmlElement, DMMath.Accent? value)
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
  
  private static DMMath.Bar? GetBar(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (element != null)
      return DMXMath.BarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar(DXW.Hyperlink openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Bar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBar(DXW.Hyperlink openXmlElement, DMMath.Bar? value)
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
  
  private static DMMath.Box? GetBox(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (element != null)
      return DMXMath.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXW.Hyperlink openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBox(DXW.Hyperlink openXmlElement, DMMath.Box? value)
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
  
  private static DMMath.BorderBox? GetBorderBox(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (element != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBox(DXW.Hyperlink openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorderBox(DXW.Hyperlink openXmlElement, DMMath.BorderBox? value)
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
  
  private static DMMath.Delimiter? GetDelimiter(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (element != null)
      return DMXMath.DelimiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiter(DXW.Hyperlink openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDelimiter(DXW.Hyperlink openXmlElement, DMMath.Delimiter? value)
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
  
  private static DMMath.EquationArray? GetEquationArray(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (element != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArray(DXW.Hyperlink openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEquationArray(DXW.Hyperlink openXmlElement, DMMath.EquationArray? value)
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
  
  private static DMMath.Fraction? GetFraction(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (element != null)
      return DMXMath.FractionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFraction(DXW.Hyperlink openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Fraction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFraction(DXW.Hyperlink openXmlElement, DMMath.Fraction? value)
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
  
  private static DMMath.MathFunction? GetMathFunction(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (element != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathFunction(DXW.Hyperlink openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathFunction(DXW.Hyperlink openXmlElement, DMMath.MathFunction? value)
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
  
  private static DMMath.GroupChar? GetGroupChar(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (element != null)
      return DMXMath.GroupCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupChar(DXW.Hyperlink openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupChar(DXW.Hyperlink openXmlElement, DMMath.GroupChar? value)
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
  
  private static DMMath.LimitLower? GetLimitLower(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (element != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLower(DXW.Hyperlink openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLower(DXW.Hyperlink openXmlElement, DMMath.LimitLower? value)
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
  
  private static DMMath.LimitUpper? GetLimitUpper(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (element != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpper(DXW.Hyperlink openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitUpper(DXW.Hyperlink openXmlElement, DMMath.LimitUpper? value)
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
  
  private static DMMath.Matrix? GetMatrix(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (element != null)
      return DMXMath.MatrixConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrix(DXW.Hyperlink openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Matrix>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrix(DXW.Hyperlink openXmlElement, DMMath.Matrix? value)
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
  
  private static DMMath.Nary? GetNary(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (element != null)
      return DMXMath.NaryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNary(DXW.Hyperlink openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Nary>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNary(DXW.Hyperlink openXmlElement, DMMath.Nary? value)
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
  
  private static DMMath.Phantom? GetPhantom(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (element != null)
      return DMXMath.PhantomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantom(DXW.Hyperlink openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Phantom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPhantom(DXW.Hyperlink openXmlElement, DMMath.Phantom? value)
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
  
  private static DMMath.Radical? GetRadical(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (element != null)
      return DMXMath.RadicalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadical(DXW.Hyperlink openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Radical>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadical(DXW.Hyperlink openXmlElement, DMMath.Radical? value)
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
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (element != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuper(DXW.Hyperlink openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreSubSuper(DXW.Hyperlink openXmlElement, DMMath.PreSubSuper? value)
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
  
  private static DMMath.Subscript? GetSubscript(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (element != null)
      return DMXMath.SubscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscript(DXW.Hyperlink openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Subscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubscript(DXW.Hyperlink openXmlElement, DMMath.Subscript? value)
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
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (element != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscript(DXW.Hyperlink openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubSuperscript(DXW.Hyperlink openXmlElement, DMMath.SubSuperscript? value)
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
  
  private static DMMath.Superscript? GetSuperscript(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (element != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscript(DXW.Hyperlink openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Superscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperscript(DXW.Hyperlink openXmlElement, DMMath.Superscript? value)
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
  
  private static DMMath.Run? GetRun(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (element != null)
      return DMXMath.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXW.Hyperlink openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Run>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRun(DXW.Hyperlink openXmlElement, DMMath.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunConverter.CreateOpenXmlElement<DXMath.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalOverride? GetBidirectionalOverride(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>();
    if (element != null)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalOverride(DXW.Hyperlink openXmlElement, DMW.BidirectionalOverride? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalOverride>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBidirectionalOverride(DXW.Hyperlink openXmlElement, DMW.BidirectionalOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement<DXW.BidirectionalOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalEmbedding? GetBidirectionalEmbedding(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (element != null)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalEmbedding(DXW.Hyperlink openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBidirectionalEmbedding(DXW.Hyperlink openXmlElement, DMW.BidirectionalEmbedding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement<DXW.BidirectionalEmbedding>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetSubDocumentReference(DXW.Hyperlink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SubDocumentReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubDocumentReference(DXW.Hyperlink openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SubDocumentReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubDocumentReference(DXW.Hyperlink openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SubDocumentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SubDocumentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Hyperlink? CreateModelElement(DXW.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Hyperlink();
      value.TargetFrame = GetTargetFrame(openXmlElement);
      value.Tooltip = GetTooltip(openXmlElement);
      value.DocLocation = GetDocLocation(openXmlElement);
      value.History = GetHistory(openXmlElement);
      value.Anchor = GetAnchor(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      value.SimpleFields = GetSimpleFields(openXmlElement);
      value.ChildHyperlink = GetChildHyperlink(openXmlElement);
      value.SdtRun = GetSdtRun(openXmlElement);
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
      value.Run = GetRun(openXmlElement);
      value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      value.SubDocumentReference = GetSubDocumentReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Hyperlink? openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
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
      if (!CmpCustomXmlRun(openXmlElement, value.CustomXmlRun, diffs, objName))
        ok = false;
      if (!CmpSimpleFields(openXmlElement, value.SimpleFields, diffs, objName))
        ok = false;
      if (!CmpChildHyperlink(openXmlElement, value.ChildHyperlink, diffs, objName))
        ok = false;
      if (!CmpSdtRun(openXmlElement, value.SdtRun, diffs, objName))
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
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpBidirectionalOverride(openXmlElement, value.BidirectionalOverride, diffs, objName))
        ok = false;
      if (!CmpBidirectionalEmbedding(openXmlElement, value.BidirectionalEmbedding, diffs, objName))
        ok = false;
      if (!CmpSubDocumentReference(openXmlElement, value.SubDocumentReference, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Hyperlink value)
    where OpenXmlElementType: DXW.Hyperlink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Hyperlink openXmlElement, DMW.Hyperlink value)
  {
    SetTargetFrame(openXmlElement, value?.TargetFrame);
    SetTooltip(openXmlElement, value?.Tooltip);
    SetDocLocation(openXmlElement, value?.DocLocation);
    SetHistory(openXmlElement, value?.History);
    SetAnchor(openXmlElement, value?.Anchor);
    SetId(openXmlElement, value?.Id);
    SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
    SetSimpleFields(openXmlElement, value?.SimpleFields);
    SetChildHyperlink(openXmlElement, value?.ChildHyperlink);
    SetSdtRun(openXmlElement, value?.SdtRun);
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
    SetRun(openXmlElement, value?.Run);
    SetBidirectionalOverride(openXmlElement, value?.BidirectionalOverride);
    SetBidirectionalEmbedding(openXmlElement, value?.BidirectionalEmbedding);
    SetSubDocumentReference(openXmlElement, value?.SubDocumentReference);
    }
  }
