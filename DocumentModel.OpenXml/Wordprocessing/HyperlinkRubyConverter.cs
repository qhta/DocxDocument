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
    return openXmlElement?.TargetFrame?.Value;
  }
  
  private static void SetTargetFrame(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TargetFrame = new StringValue { Value = value };
    else
      openXmlElement.TargetFrame = null;
  }
  
  /// <summary>
  /// tooltip
  /// </summary>
  private static String? GetTooltip(DXW.HyperlinkRuby openXmlElement)
  {
    return openXmlElement?.Tooltip?.Value;
  }
  
  private static void SetTooltip(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tooltip = new StringValue { Value = value };
    else
      openXmlElement.Tooltip = null;
  }
  
  /// <summary>
  /// docLocation
  /// </summary>
  private static String? GetDocLocation(DXW.HyperlinkRuby openXmlElement)
  {
    return openXmlElement?.DocLocation?.Value;
  }
  
  private static void SetDocLocation(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DocLocation = new StringValue { Value = value };
    else
      openXmlElement.DocLocation = null;
  }
  
  /// <summary>
  /// history
  /// </summary>
  private static Boolean? GetHistory(DXW.HyperlinkRuby openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }
  
  private static void SetHistory(DXW.HyperlinkRuby openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.History = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.History = null;
  }
  
  /// <summary>
  /// anchor
  /// </summary>
  private static String? GetAnchor(DXW.HyperlinkRuby openXmlElement)
  {
    return openXmlElement?.Anchor?.Value;
  }
  
  private static void SetAnchor(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Anchor = new StringValue { Value = value };
    else
      openXmlElement.Anchor = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.HyperlinkRuby openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  private static DMW.CustomXmlRuby? GetCustomXmlRuby(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlRuby>();
    if (itemElement != null)
      return DMXW.CustomXmlRubyConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SimpleFieldRuby>();
    if (itemElement != null)
      return DMXW.SimpleFieldRubyConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.HyperlinkRuby>();
    if (itemElement != null)
      return DMXW.HyperlinkRubyConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Run>();
    if (itemElement != null)
      return DMXW.RunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtRunRuby>();
    if (itemElement != null)
      return DMXW.SdtRunRubyConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      return DMXW.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProofError(DXW.HyperlinkRuby openXmlElement, DMW.ProofError? value)
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
  
  private static DMW.PermStart? GetPermStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      return DMXW.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermStart(DXW.HyperlinkRuby openXmlElement, DMW.PermStart? value)
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
  
  private static DMW.PermEnd? GetPermEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      return DMXW.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermEnd(DXW.HyperlinkRuby openXmlElement, DMW.PermEnd? value)
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
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkStart(DXW.HyperlinkRuby openXmlElement, DMW.BookmarkStart? value)
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
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.HyperlinkRuby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      return DMXW.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      return DMXW.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      return DMXW.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      return DMXMath.ParagraphConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      return DMXMath.AccentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      return DMXMath.BarConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      return DMXMath.BoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      return DMXMath.DelimiterConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      return DMXMath.FractionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      return DMXMath.GroupCharConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      return DMXMath.MatrixConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      return DMXMath.NaryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      return DMXMath.PhantomConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      return DMXMath.RadicalConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      return DMXMath.SubscriptConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.HyperlinkRuby? value)
    where OpenXmlElementType: DXW.HyperlinkRuby, new()
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
      return openXmlElement;
    }
    return default;
  }
}
