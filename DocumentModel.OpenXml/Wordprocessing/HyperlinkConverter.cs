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
    return openXmlElement?.TargetFrame?.Value;
  }
  
  private static void SetTargetFrame(DXW.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TargetFrame = new StringValue { Value = value };
    else
      openXmlElement.TargetFrame = null;
  }
  
  /// <summary>
  /// Associated String
  /// </summary>
  private static String? GetTooltip(DXW.Hyperlink openXmlElement)
  {
    return openXmlElement?.Tooltip?.Value;
  }
  
  private static void SetTooltip(DXW.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tooltip = new StringValue { Value = value };
    else
      openXmlElement.Tooltip = null;
  }
  
  /// <summary>
  /// Location in Target Document
  /// </summary>
  private static String? GetDocLocation(DXW.Hyperlink openXmlElement)
  {
    return openXmlElement?.DocLocation?.Value;
  }
  
  private static void SetDocLocation(DXW.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DocLocation = new StringValue { Value = value };
    else
      openXmlElement.DocLocation = null;
  }
  
  /// <summary>
  /// Add To Viewed Hyperlinks
  /// </summary>
  private static Boolean? GetHistory(DXW.Hyperlink openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }
  
  private static void SetHistory(DXW.Hyperlink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.History = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.History = null;
  }
  
  /// <summary>
  /// Hyperlink Anchor
  /// </summary>
  private static String? GetAnchor(DXW.Hyperlink openXmlElement)
  {
    return openXmlElement?.Anchor?.Value;
  }
  
  private static void SetAnchor(DXW.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Anchor = new StringValue { Value = value };
    else
      openXmlElement.Anchor = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetId(DXW.Hyperlink openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  private static DMW.CustomXmlRun? GetCustomXmlRun(DXW.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      return DMXW.CustomXmlRunConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static Collection<DMW.SimpleField> GetSimpleFields(DXW.Hyperlink openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      return DMXW.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      return DMXW.SdtRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      return DMXW.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      return DMXW.PermStartConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      return DMXW.PermEndConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      return DMXW.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      return DMXW.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      return DMXW.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      return DMXMath.ParagraphConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      return DMXMath.AccentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      return DMXMath.BarConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      return DMXMath.BoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      return DMXMath.DelimiterConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      return DMXMath.FractionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      return DMXMath.GroupCharConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      return DMXMath.MatrixConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      return DMXMath.NaryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      return DMXMath.PhantomConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      return DMXMath.RadicalConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      return DMXMath.SubscriptConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      return DMXMath.RunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SubDocumentReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.Hyperlink? CreateModelElement(DXW.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Hyperlink();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Hyperlink? value)
    where OpenXmlElementType: DXW.Hyperlink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
