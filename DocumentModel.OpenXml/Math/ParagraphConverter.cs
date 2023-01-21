namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  private static DMMath.ParagraphProperties? GetParagraphProperties(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ParagraphProperties>();
    if (itemElement != null)
      return DMXMath.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphProperties(DXMath.Paragraph openXmlElement, DMMath.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphPropertiesConverter.CreateOpenXmlElement<DXMath.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeMath(DXMath.Paragraph openXmlElement, DMMath.OfficeMath? value)
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
  
  private static DMMath.Run? GetRun(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      return DMXMath.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRun(DXMath.Paragraph openXmlElement, DMMath.Run? value)
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
  
  private static DMW.ProofError? GetProofError(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      return DMXW.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProofError(DXMath.Paragraph openXmlElement, DMW.ProofError? value)
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
  
  private static DMW.PermStart? GetPermStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      return DMXW.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermStart(DXMath.Paragraph openXmlElement, DMW.PermStart? value)
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
  
  private static DMW.PermEnd? GetPermEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      return DMXW.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermEnd(DXMath.Paragraph openXmlElement, DMW.PermEnd? value)
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
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkStart(DXMath.Paragraph openXmlElement, DMW.BookmarkStart? value)
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
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkEnd(DXMath.Paragraph openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeStart(DXMath.Paragraph openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeStart(DXMath.Paragraph openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeStart(DXMath.Paragraph openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXMath.Paragraph openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DMXW.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXMath.Paragraph openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.InsertedRun? GetInsertedRun(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      return DMXW.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedRun(DXMath.Paragraph openXmlElement, DMW.InsertedRun? value)
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
  
  private static DMW.DeletedRun? GetDeletedRun(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      return DMXW.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedRun(DXMath.Paragraph openXmlElement, DMW.DeletedRun? value)
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
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRun(DXMath.Paragraph openXmlElement, DMW.MoveFromRun? value)
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
  
  private static DMW.MoveToRun? GetMoveToRun(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      return DMXW.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRun(DXMath.Paragraph openXmlElement, DMW.MoveToRun? value)
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
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictInsertion(DXMath.Paragraph openXmlElement, DMW.RunConflictInsertion? value)
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
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXMath.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictDeletion(DXMath.Paragraph openXmlElement, DMW.RunConflictDeletion? value)
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
  
  public static DMMath.Paragraph? CreateModelElement(DXMath.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Paragraph();
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Run = GetRun(openXmlElement);
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
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Paragraph? value)
    where OpenXmlElementType: DXMath.Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetOfficeMath(openXmlElement, value?.OfficeMath);
      SetRun(openXmlElement, value?.Run);
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
      return openXmlElement;
    }
    return default;
  }
}
