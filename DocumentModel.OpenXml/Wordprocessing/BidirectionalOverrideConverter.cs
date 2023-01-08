namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BidirectionalOverride Class.
/// </summary>
public static class BidirectionalOverrideConverter
{
  /// <summary>
  /// val
  /// </summary>
  public static DocumentModel.Wordprocessing.DirectionKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DirectionValues, DocumentModel.Wordprocessing.DirectionKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.DirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DirectionValues, DocumentModel.Wordprocessing.DirectionKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlRun? GetCustomXmlRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.CustomXmlRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.SimpleField>? GetSimpleFields(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSimpleFields(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.SimpleField>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.Hyperlink? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtRun? GetSdtRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.SdtRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Paragraph? GetParagraph(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetParagraph(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Paragraph? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.OfficeMath? GetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.OfficeMath? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Accent? GetAccent(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAccent(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Accent? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Bar? GetBar(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBar(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Bar? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Box? GetBox(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBox(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Box? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.BorderBox? GetBorderBox(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBorderBox(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.BorderBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Delimiter? GetDelimiter(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDelimiter(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Delimiter? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.EquationArray? GetEquationArray(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEquationArray(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.EquationArray? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Fraction? GetFraction(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFraction(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Fraction? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.MathFunction? GetMathFunction(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMathFunction(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.MathFunction? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.GroupChar? GetGroupChar(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupChar(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.GroupChar? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.LimitLower? GetLimitLower(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLimitLower(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.LimitLower? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.LimitUpper? GetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.LimitUpper? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Matrix? GetMatrix(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMatrix(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Matrix? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Nary? GetNary(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNary(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Nary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Phantom? GetPhantom(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPhantom(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Phantom? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Radical? GetRadical(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadical(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Radical? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.PreSubSuper? GetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.PreSubSuper? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Subscript? GetSubscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSubscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Subscript? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.SubSuperscript? GetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.SubSuperscript? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Superscript? GetSuperscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSuperscript(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Superscript? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.Run? GetRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRun(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Math.Run? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.BidirectionalOverride? GetChildBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.BidirectionalOverride? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.BidirectionalEmbedding? GetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.BidirectionalEmbedding? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetSubDocumentReference(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSubDocumentReference(DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
