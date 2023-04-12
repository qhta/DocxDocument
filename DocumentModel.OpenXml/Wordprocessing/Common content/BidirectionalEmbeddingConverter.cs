namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.BidirectionalEmbedding"/> class from/to OpenXml converter.
/// </summary>
public static class BidirectionalEmbeddingConverter
{
  #region Type conversion.
  private static DMW.DirectionKind? GetVal(DXW.BidirectionalEmbedding openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.BidirectionalEmbedding openXmlElement, DMW.DirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.BidirectionalEmbedding openXmlElement, DMW.DirectionKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DirectionValues, DMW.DirectionKind>(value);
  }
  #endregion

  
  public static DMW.BidirectionalEmbedding? CreateModelElement(DXW.BidirectionalEmbedding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BidirectionalEmbedding();
      value.Type = GetVal(openXmlElement);
      //value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      //value.SimpleFields = GetSimpleFields(openXmlElement);
      //value.Hyperlink = GetHyperlink(openXmlElement);
      //value.SdtRun = GetSdtRun(openXmlElement);
      //value.ProofError = GetProofError(openXmlElement);
      //value.PermStart = GetPermStart(openXmlElement);
      //value.PermEnd = GetPermEnd(openXmlElement);
      //value.BookmarkStart = GetBookmarkStart(openXmlElement);
      //value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      //value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      //value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      //value.MoveFromRangeStart = GetMoveFromRangeStart(openXmlElement);
      //value.MoveFromRangeEnd = GetMoveFromRangeEnd(openXmlElement);
      //value.MoveToRangeStart = GetMoveToRangeStart(openXmlElement);
      //value.MoveToRangeEnd = GetMoveToRangeEnd(openXmlElement);
      //value.CustomXmlInsRangeStart = GetCustomXmlInsRangeStart(openXmlElement);
      //value.CustomXmlInsRangeEnd = GetCustomXmlInsRangeEnd(openXmlElement);
      //value.CustomXmlDelRangeStart = GetCustomXmlDelRangeStart(openXmlElement);
      //value.CustomXmlDelRangeEnd = GetCustomXmlDelRangeEnd(openXmlElement);
      //value.CustomXmlMoveFromRangeStart = GetCustomXmlMoveFromRangeStart(openXmlElement);
      //value.CustomXmlMoveFromRangeEnd = GetCustomXmlMoveFromRangeEnd(openXmlElement);
      //value.CustomXmlMoveToRangeStart = GetCustomXmlMoveToRangeStart(openXmlElement);
      //value.CustomXmlMoveToRangeEnd = GetCustomXmlMoveToRangeEnd(openXmlElement);
      //value.CustomXmlConflictInsertionRangeStart = GetCustomXmlConflictInsertionRangeStart(openXmlElement);
      //value.CustomXmlConflictInsertionRangeEnd = GetCustomXmlConflictInsertionRangeEnd(openXmlElement);
      //value.CustomXmlConflictDeletionRangeStart = GetCustomXmlConflictDeletionRangeStart(openXmlElement);
      //value.CustomXmlConflictDeletionRangeEnd = GetCustomXmlConflictDeletionRangeEnd(openXmlElement);
      //value.InsertedRun = GetInsertedRun(openXmlElement);
      //value.DeletedRun = GetDeletedRun(openXmlElement);
      //value.MoveFromRun = GetMoveFromRun(openXmlElement);
      //value.MoveToRun = GetMoveToRun(openXmlElement);
      //value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      //value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      //value.Paragraph = GetParagraph(openXmlElement);
      //value.OfficeMath = GetOfficeMath(openXmlElement);
      //value.Accent = GetAccent(openXmlElement);
      //value.Bar = GetBar(openXmlElement);
      //value.Box = GetBox(openXmlElement);
      //value.BorderBox = GetBorderBox(openXmlElement);
      //value.Delimiter = GetDelimiter(openXmlElement);
      //value.EquationArray = GetEquationArray(openXmlElement);
      //value.Fraction = GetFraction(openXmlElement);
      //value.MathFunction = GetMathFunction(openXmlElement);
      //value.GroupChar = GetGroupChar(openXmlElement);
      //value.LimitLower = GetLimitLower(openXmlElement);
      //value.LimitUpper = GetLimitUpper(openXmlElement);
      //value.Matrix = GetMatrix(openXmlElement);
      //value.Nary = GetNary(openXmlElement);
      //value.Phantom = GetPhantom(openXmlElement);
      //value.Radical = GetRadical(openXmlElement);
      //value.PreSubSuper = GetPreSubSuper(openXmlElement);
      //value.Subscript = GetSubscript(openXmlElement);
      //value.SubSuperscript = GetSubSuperscript(openXmlElement);
      //value.Superscript = GetSuperscript(openXmlElement);
      //value.Run = GetRun(openXmlElement);
      //value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      //value.ChildBidirectionalEmbedding = GetChildBidirectionalEmbedding(openXmlElement);
      //value.SubDocumentReference = GetSubDocumentReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BidirectionalEmbedding? openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName))
        ok = false;
      //if (!CmpCustomXmlRun(openXmlElement, value.CustomXmlRun, diffs, objName))
      //  ok = false;
      //if (!CmpSimpleFields(openXmlElement, value.SimpleFields, diffs, objName))
      //  ok = false;
      //if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
      //  ok = false;
      //if (!CmpSdtRun(openXmlElement, value.SdtRun, diffs, objName))
      //  ok = false;
      //if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
      //  ok = false;
      //if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
      //  ok = false;
      //if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
      //  ok = false;
      //if (!CmpBookmarkStart(openXmlElement, value.BookmarkStart, diffs, objName))
      //  ok = false;
      //if (!CmpBookmarkEnd(openXmlElement, value.BookmarkEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCommentRangeStart(openXmlElement, value.CommentRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCommentRangeEnd(openXmlElement, value.CommentRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpMoveFromRangeStart(openXmlElement, value.MoveFromRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpMoveFromRangeEnd(openXmlElement, value.MoveFromRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpMoveToRangeStart(openXmlElement, value.MoveToRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpMoveToRangeEnd(openXmlElement, value.MoveToRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlInsRangeStart(openXmlElement, value.CustomXmlInsRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlInsRangeEnd(openXmlElement, value.CustomXmlInsRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlDelRangeStart(openXmlElement, value.CustomXmlDelRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlDelRangeEnd(openXmlElement, value.CustomXmlDelRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlMoveFromRangeStart(openXmlElement, value.CustomXmlMoveFromRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlMoveFromRangeEnd(openXmlElement, value.CustomXmlMoveFromRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlMoveToRangeStart(openXmlElement, value.CustomXmlMoveToRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlMoveToRangeEnd(openXmlElement, value.CustomXmlMoveToRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlConflictInsertionRangeStart(openXmlElement, value.CustomXmlConflictInsertionRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlConflictInsertionRangeEnd(openXmlElement, value.CustomXmlConflictInsertionRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlConflictDeletionRangeStart(openXmlElement, value.CustomXmlConflictDeletionRangeStart, diffs, objName))
      //  ok = false;
      //if (!CmpCustomXmlConflictDeletionRangeEnd(openXmlElement, value.CustomXmlConflictDeletionRangeEnd, diffs, objName))
      //  ok = false;
      //if (!CmpInsertedRun(openXmlElement, value.InsertedRun, diffs, objName))
      //  ok = false;
      //if (!CmpDeletedRun(openXmlElement, value.DeletedRun, diffs, objName))
      //  ok = false;
      //if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
      //  ok = false;
      //if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
      //  ok = false;
      //if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
      //  ok = false;
      //if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
      //  ok = false;
      //if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
      //  ok = false;
      //if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
      //  ok = false;
      //if (!CmpAccent(openXmlElement, value.Accent, diffs, objName))
      //  ok = false;
      //if (!CmpBar(openXmlElement, value.Bar, diffs, objName))
      //  ok = false;
      //if (!CmpBox(openXmlElement, value.Box, diffs, objName))
      //  ok = false;
      //if (!CmpBorderBox(openXmlElement, value.BorderBox, diffs, objName))
      //  ok = false;
      //if (!CmpDelimiter(openXmlElement, value.Delimiter, diffs, objName))
      //  ok = false;
      //if (!CmpEquationArray(openXmlElement, value.EquationArray, diffs, objName))
      //  ok = false;
      //if (!CmpFraction(openXmlElement, value.Fraction, diffs, objName))
      //  ok = false;
      //if (!CmpMathFunction(openXmlElement, value.MathFunction, diffs, objName))
      //  ok = false;
      //if (!CmpGroupChar(openXmlElement, value.GroupChar, diffs, objName))
      //  ok = false;
      //if (!CmpLimitLower(openXmlElement, value.LimitLower, diffs, objName))
      //  ok = false;
      //if (!CmpLimitUpper(openXmlElement, value.LimitUpper, diffs, objName))
      //  ok = false;
      //if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
      //  ok = false;
      //if (!CmpNary(openXmlElement, value.Nary, diffs, objName))
      //  ok = false;
      //if (!CmpPhantom(openXmlElement, value.Phantom, diffs, objName))
      //  ok = false;
      //if (!CmpRadical(openXmlElement, value.Radical, diffs, objName))
      //  ok = false;
      //if (!CmpPreSubSuper(openXmlElement, value.PreSubSuper, diffs, objName))
      //  ok = false;
      //if (!CmpSubscript(openXmlElement, value.Subscript, diffs, objName))
      //  ok = false;
      //if (!CmpSubSuperscript(openXmlElement, value.SubSuperscript, diffs, objName))
      //  ok = false;
      //if (!CmpSuperscript(openXmlElement, value.Superscript, diffs, objName))
      //  ok = false;
      //if (!CmpRun(openXmlElement, value.Run, diffs, objName))
      //  ok = false;
      //if (!CmpBidirectionalOverride(openXmlElement, value.BidirectionalOverride, diffs, objName))
      //  ok = false;
      //if (!CmpChildBidirectionalEmbedding(openXmlElement, value.ChildBidirectionalEmbedding, diffs, objName))
      //  ok = false;
      //if (!CmpSubDocumentReference(openXmlElement, value.SubDocumentReference, diffs, objName))
      //  ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.BidirectionalEmbedding CreateOpenXmlElement(DMW.BidirectionalEmbedding value)
  {
    var openXmlElement = new DXW.BidirectionalEmbedding();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.BidirectionalEmbedding openXmlElement, DMW.BidirectionalEmbedding value)
  {
    SetVal(openXmlElement, value?.Type);
    //SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
    //SetSimpleFields(openXmlElement, value?.SimpleFields);
    //SetHyperlink(openXmlElement, value?.Hyperlink);
    //SetSdtRun(openXmlElement, value?.SdtRun);
    //SetProofError(openXmlElement, value?.ProofError);
    //SetPermStart(openXmlElement, value?.PermStart);
    //SetPermEnd(openXmlElement, value?.PermEnd);
    //SetBookmarkStart(openXmlElement, value?.BookmarkStart);
    //SetBookmarkEnd(openXmlElement, value?.BookmarkEnd);
    //SetCommentRangeStart(openXmlElement, value?.CommentRangeStart);
    //SetCommentRangeEnd(openXmlElement, value?.CommentRangeEnd);
    //SetMoveFromRangeStart(openXmlElement, value?.MoveFromRangeStart);
    //SetMoveFromRangeEnd(openXmlElement, value?.MoveFromRangeEnd);
    //SetMoveToRangeStart(openXmlElement, value?.MoveToRangeStart);
    //SetMoveToRangeEnd(openXmlElement, value?.MoveToRangeEnd);
    //SetCustomXmlInsRangeStart(openXmlElement, value?.CustomXmlInsRangeStart);
    //SetCustomXmlInsRangeEnd(openXmlElement, value?.CustomXmlInsRangeEnd);
    //SetCustomXmlDelRangeStart(openXmlElement, value?.CustomXmlDelRangeStart);
    //SetCustomXmlDelRangeEnd(openXmlElement, value?.CustomXmlDelRangeEnd);
    //SetCustomXmlMoveFromRangeStart(openXmlElement, value?.CustomXmlMoveFromRangeStart);
    //SetCustomXmlMoveFromRangeEnd(openXmlElement, value?.CustomXmlMoveFromRangeEnd);
    //SetCustomXmlMoveToRangeStart(openXmlElement, value?.CustomXmlMoveToRangeStart);
    //SetCustomXmlMoveToRangeEnd(openXmlElement, value?.CustomXmlMoveToRangeEnd);
    //SetCustomXmlConflictInsertionRangeStart(openXmlElement, value?.CustomXmlConflictInsertionRangeStart);
    //SetCustomXmlConflictInsertionRangeEnd(openXmlElement, value?.CustomXmlConflictInsertionRangeEnd);
    //SetCustomXmlConflictDeletionRangeStart(openXmlElement, value?.CustomXmlConflictDeletionRangeStart);
    //SetCustomXmlConflictDeletionRangeEnd(openXmlElement, value?.CustomXmlConflictDeletionRangeEnd);
    //SetInsertedRun(openXmlElement, value?.InsertedRun);
    //SetDeletedRun(openXmlElement, value?.DeletedRun);
    //SetMoveFromRun(openXmlElement, value?.MoveFromRun);
    //SetMoveToRun(openXmlElement, value?.MoveToRun);
    //SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
    //SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
    //SetParagraph(openXmlElement, value?.Paragraph);
    //SetOfficeMath(openXmlElement, value?.OfficeMath);
    //SetAccent(openXmlElement, value?.Accent);
    //SetBar(openXmlElement, value?.Bar);
    //SetBox(openXmlElement, value?.Box);
    //SetBorderBox(openXmlElement, value?.BorderBox);
    //SetDelimiter(openXmlElement, value?.Delimiter);
    //SetEquationArray(openXmlElement, value?.EquationArray);
    //SetFraction(openXmlElement, value?.Fraction);
    //SetMathFunction(openXmlElement, value?.MathFunction);
    //SetGroupChar(openXmlElement, value?.GroupChar);
    //SetLimitLower(openXmlElement, value?.LimitLower);
    //SetLimitUpper(openXmlElement, value?.LimitUpper);
    //SetMatrix(openXmlElement, value?.Matrix);
    //SetNary(openXmlElement, value?.Nary);
    //SetPhantom(openXmlElement, value?.Phantom);
    //SetRadical(openXmlElement, value?.Radical);
    //SetPreSubSuper(openXmlElement, value?.PreSubSuper);
    //SetSubscript(openXmlElement, value?.Subscript);
    //SetSubSuperscript(openXmlElement, value?.SubSuperscript);
    //SetSuperscript(openXmlElement, value?.Superscript);
    //SetRun(openXmlElement, value?.Run);
    //SetBidirectionalOverride(openXmlElement, value?.BidirectionalOverride);
    //SetChildBidirectionalEmbedding(openXmlElement, value?.ChildBidirectionalEmbedding);
    //SetSubDocumentReference(openXmlElement, value?.SubDocumentReference);
    return true;
  }
}
