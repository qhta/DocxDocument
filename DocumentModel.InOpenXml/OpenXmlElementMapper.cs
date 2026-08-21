namespace DocumentModel;

/// <summary>
/// The class that maps OpenXml elements to the corresponding model elements in the DocumentModel namespace.
/// </summary>
public static class OpenXmlElementMapper
{
  /// <summary>
  /// Scans the provided list of model element types and populates the mapping dictionaries for OpenXml element types to model element types and vice versa.
  /// This method uses reflection to find the OpenXmlTypeAttribute on each model type to determine the corresponding OpenXml type.
  /// </summary>
  /// <param name="typeList">List of model element types to scan.</param>
  public static void ScanModelElements(Type[] typeList)
  {
    foreach (var modelType in typeList)
    {
      if (ModelType2OpenXmlElementMapping.ContainsKey(modelType))
        continue;

      var openXmlTypeAttributes = modelType.GetCustomAttributes<OpenXmlTypeAttribute>().ToArray();
      if (openXmlTypeAttributes.Any())
      {
        var openXmlTypes = openXmlTypeAttributes.Select(attr => attr.Type).ToArray();
        foreach (var openXmlType in openXmlTypes)
        {
          if (!OpenXml2ModelElementTypeMapping.TryGetValue(openXmlType, out var existingModelType))
            OpenXml2ModelElementTypeMapping.Add(openXmlType, modelType);
          else
          if (existingModelType != modelType)
              throw new ApplicationException($"Conflicting model element type mapping for OpenXml type {openXmlType.FullName}: {existingModelType.FullName} and {modelType.FullName}");
        }
        ModelType2OpenXmlElementMapping.Add(modelType, openXmlTypes);
      }
    }
  }

  /// <summary>
  /// Gets the corresponding model element type for the specified OpenXml type. If no mapping is found, an ApplicationException is thrown.
  /// </summary>
  /// <param name="openXmlType">The OpenXml type to get the corresponding model element type for.</param>
  /// <returns>The corresponding model element type.</returns>
  /// <exception cref="ApplicationException"></exception>
  public static Type GetModelElementType(Type openXmlType)
  {
    if (OpenXml2ModelElementTypeMapping.TryGetValue(openXmlType, out var modelType))
      return modelType;
    throw new ApplicationException($"No model element type mapping found for OpenXml type {openXmlType.FullName}");
  }
  
  /// <summary>
  /// Gets the corresponding OpenXml element types for the specified model type. If no mapping is found, an ApplicationException is thrown.
  /// </summary>
  /// <param name="modelType">The model type to get the corresponding OpenXml element types for.</param>
  /// <returns>The corresponding OpenXml element types.</returns>
  /// <exception cref="ApplicationException"></exception>
  public static Type[] GetOpenXmlElementTypes(Type modelType)
  {
    if (ModelType2OpenXmlElementMapping.TryGetValue(modelType, out var openXmlTypes))
      return openXmlTypes;
    ScanModelElements([modelType]);
    if (ModelType2OpenXmlElementMapping.TryGetValue(modelType, out openXmlTypes))
      return openXmlTypes;
    throw new ApplicationException($"No OpenXml element type mapping found for model type {modelType.FullName}");
  }

  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type> OpenXml2ModelElementTypeMapping = new()
  {
    { typeof(DX.AlternateContent), typeof(DM.AlternateContent) },
    { typeof(DXM.Accent), typeof(DMM.Accent) },
    { typeof(DXM.Bar), typeof(DMM.Bar) },
    { typeof(DXM.BorderBox), typeof(DMM.BorderBox) },
    { typeof(DXM.Box), typeof(DMM.Box) },
    { typeof(DXM.Delimiter), typeof(DMM.Delimiter) },
    { typeof(DXM.EquationArray), typeof(DMM.EquationArray) },
    { typeof(DXM.Fraction), typeof(DMM.Fraction) },
    { typeof(DXM.GroupChar), typeof(DMM.GroupChar) },
    { typeof(DXM.LimitLower), typeof(DMM.LimitLower) },
    { typeof(DXM.LimitUpper), typeof(DMM.LimitUpper) },
    { typeof(DXM.MathFunction), typeof(DMM.Function) },
    { typeof(DXM.Matrix), typeof(DMM.Matrix) },
    { typeof(DXM.Nary), typeof(DMM.Nary) },
    { typeof(DXM.OfficeMath), typeof(DMM.OfficeMath) },
    { typeof(DXM.Paragraph), typeof(DMM.Paragraph) },
    { typeof(DXM.Phantom), typeof(DMM.Phantom) },
    { typeof(DXM.PreSubSuper), typeof(DMM.PreSubSuper) },
    { typeof(DXM.Radical), typeof(DMM.Radical) },
    { typeof(DXM.Run), typeof(DMM.Run) },
    { typeof(DXM.Subscript), typeof(DMM.Subscript) },
    { typeof(DXM.SubSuperscript), typeof(DMM.SubSuperscript) },
    { typeof(DXM.Superscript), typeof(DMM.Superscript) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeEnd), typeof(DMW.CustomXmlConflictDeletionRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeStart), typeof(DMW.CustomXmlConflictDeletionRangeStart) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeEnd), typeof(DMW.CustomXmlConflictInsertionRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeStart), typeof(DMW.CustomXmlConflictInsertionRangeStart) },
    { typeof(DXO10W.RunConflictDeletion), typeof(DMW.RunConflictDeletion) },
    { typeof(DXO10W.RunConflictInsertion), typeof(DMW.RunConflictInsertion) },
    { typeof(DXW.AltChunk), typeof(DMW.AltChunk) },
    { typeof(DXW.AnnotationReferenceMark), typeof(DMW.AnnotationReferenceMark) },
    { typeof(DXW.BidirectionalEmbedding), typeof(DMW.BidirectionalEmbedding) },
    { typeof(DXW.BidirectionalOverride), typeof(DMW.BidirectionalOverride) },
    { typeof(DXW.BookmarkEnd), typeof(DMW.BookmarkEnd) },
    { typeof(DXW.BookmarkStart), typeof(DMW.BookmarkStart) },
    { typeof(DXW.Break), typeof(DMW.Break) },
    { typeof(DXW.CarriageReturn), typeof(DMW.CarriageReturn) },
    { typeof(DXW.CommentRangeEnd), typeof(DMW.CommentRangeEnd) },
    { typeof(DXW.CommentRangeStart), typeof(DMW.CommentRangeStart) },
    { typeof(DXW.CommentReference), typeof(DMW.CommentReference) },
    { typeof(DXW.ContentPart), typeof(DMW.ContentPart) },
    { typeof(DXW.ContinuationSeparatorMark), typeof(DMW.ContinuationSeparatorMark) },
    { typeof(DXW.CustomXmlBlock), typeof(DMW.CustomXmlBlock) },
    { typeof(DXW.CustomXmlDelRangeEnd), typeof(DMW.CustomXmlDelRangeEnd) },
    { typeof(DXW.CustomXmlDelRangeStart), typeof(DMW.CustomXmlDelRangeStart) },
    { typeof(DXW.CustomXmlInsRangeEnd), typeof(DMW.CustomXmlInsRangeEnd) },
    { typeof(DXW.CustomXmlInsRangeStart), typeof(DMW.CustomXmlInsRangeStart) },
    { typeof(DXW.CustomXmlMoveFromRangeEnd), typeof(DMW.CustomXmlMoveFromRangeEnd) },
    { typeof(DXW.CustomXmlMoveFromRangeStart), typeof(DMW.CustomXmlMoveFromRangeStart) },
    { typeof(DXW.CustomXmlMoveToRangeEnd), typeof(DMW.CustomXmlMoveToRangeEnd) },
    { typeof(DXW.CustomXmlMoveToRangeStart), typeof(DMW.CustomXmlMoveToRangeStart) },
    { typeof(DXW.CustomXmlRun), typeof(DMW.CustomXmlRun) },
    { typeof(DXW.DayLong), typeof(DMW.DayLong) },
    { typeof(DXW.DayShort), typeof(DMW.DayShort) },
    { typeof(DXW.DeletedFieldCode), typeof(DMW.DeletedFieldCode) },
    { typeof(DXW.DeletedRun), typeof(DMW.DeletedRun) },
    { typeof(DXW.DeletedText), typeof(DMW.DeletedText) },
    { typeof(DXW.Drawing), typeof(DMW.Drawing) },
    { typeof(DXW.EmbeddedObject), typeof(DMW.EmbeddedObject) },
    { typeof(DXW.EndnoteReference), typeof(DMW.EndnoteReference) },
    { typeof(DXW.EndnoteReferenceMark), typeof(DMW.EndnoteReferenceMark) },
    { typeof(DXW.FieldChar), typeof(DMW.FieldChar) },
    { typeof(DXW.FieldCode), typeof(DMW.FieldCode) },
    { typeof(DXW.FootnoteReference), typeof(DMW.FootnoteReference) },
    { typeof(DXW.FootnoteReferenceMark), typeof(DMW.FootnoteReferenceMark) },
    { typeof(DXW.Hyperlink), typeof(DMW.Hyperlink) },
    { typeof(DXW.InsertedRun), typeof(DMW.InsertedRun) },
    { typeof(DXW.Languages), typeof(DMW.Languages) },
    { typeof(DXW.LastRenderedPageBreak), typeof(DMW.LastRenderedPageBreak) },
    { typeof(DXW.MonthLong), typeof(DMW.MonthLong) },
    { typeof(DXW.MonthShort), typeof(DMW.MonthShort) },
    { typeof(DXW.MoveFromRangeEnd), typeof(DMW.MoveFromRangeEnd) },
    { typeof(DXW.MoveFromRangeStart), typeof(DMW.MoveFromRangeStart) },
    { typeof(DXW.MoveFromRun), typeof(DMW.MoveFromRun) },
    { typeof(DXW.MoveToRangeEnd), typeof(DMW.MoveToRangeEnd) },
    { typeof(DXW.MoveToRangeStart), typeof(DMW.MoveToRangeStart) },
    { typeof(DXW.MoveToRun), typeof(DMW.MoveToRun) },
    { typeof(DXW.NoBreakHyphen), typeof(DMW.NoBreakHyphen) },
    { typeof(DXW.PageNumber), typeof(DMW.PageNumber) },
    { typeof(DXW.Paragraph), typeof(DMW.Paragraph) },
    { typeof(DXW.ParagraphProperties), typeof(DMW.ParagraphProperties) },
    { typeof(DXW.PermEnd), typeof(DMW.PermEnd) },
    { typeof(DXW.PermStart), typeof(DMW.PermStart) },
    { typeof(DXW.Picture), typeof(DMW.Picture) },
    { typeof(DXW.PositionalTab), typeof(DMW.PositionalTab) },
    { typeof(DXW.ProofError), typeof(DMW.ProofError) },
    { typeof(DXW.Ruby), typeof(DMW.Ruby) },
    { typeof(DXW.Run), typeof(DMW.Run) },
    { typeof(DXW.RunProperties), typeof(DMW.RunProperties) },
    { typeof(DXW.SdtBlock), typeof(DMW.SdtBlock) },
    { typeof(DXW.SdtRun), typeof(DMW.SdtRun) },
    { typeof(DXW.SectionProperties), typeof(DMW.SectionProperties) },
    { typeof(DXW.SeparatorMark), typeof(DMW.SeparatorMark) },
    { typeof(DXW.SimpleField), typeof(DMW.SimpleField) },
    { typeof(DXW.SoftHyphen), typeof(DMW.SoftHyphen) },
    { typeof(DXW.SubDocumentReference), typeof(DMW.SubDocumentReference) },
    { typeof(DXW.SymbolChar), typeof(DMW.SymbolChar) },
    { typeof(DXW.TabChar), typeof(DMW.TabChar) },
    { typeof(DXW.Table), typeof(DMW.Table) },
    { typeof(DXW.Text), typeof(DMW.RunText) },
    { typeof(DXW.YearLong), typeof(DMW.YearLong) },
    { typeof(DXW.YearShort), typeof(DMW.YearShort) },
  };

  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type[]> ModelType2OpenXmlElementMapping = new()
  {
    { typeof(DM.AlternateContent), [typeof(DX.AlternateContent)] },
    { typeof(DMM.Accent), [typeof(DXM.Accent)] },
    { typeof(DMM.Bar), [typeof(DXM.Bar)] },
    { typeof(DMM.BorderBox), [typeof(DXM.BorderBox)] },
    { typeof(DMM.Box), [typeof(DXM.Box)] },
    { typeof(DMM.Delimiter), [typeof(DXM.Delimiter)] },
    { typeof(DMM.EquationArray), [typeof(DXM.EquationArray)] },
    { typeof(DMM.Fraction), [typeof(DXM.Fraction)] },
    { typeof(DMM.Function), [typeof(DXM.MathFunction)] },
    { typeof(DMM.GroupChar), [typeof(DXM.GroupChar)] },
    { typeof(DMM.LimitLower), [typeof(DXM.LimitLower)] },
    { typeof(DMM.LimitUpper), [typeof(DXM.LimitUpper)] },
    { typeof(DMM.Matrix), [typeof(DXM.Matrix)] },
    { typeof(DMM.Nary), [typeof(DXM.Nary)] },
    { typeof(DMM.OfficeMath), [typeof(DXM.OfficeMath)] },
    { typeof(DMM.Paragraph), [typeof(DXM.Paragraph)] },
    { typeof(DMM.Phantom), [typeof(DXM.Phantom)] },
    { typeof(DMM.PreSubSuper), [typeof(DXM.PreSubSuper)] },
    { typeof(DMM.Radical), [typeof(DXM.Radical)] },
    { typeof(DMM.Run), [typeof(DXM.Run)] },
    { typeof(DMM.Subscript), [typeof(DXM.Subscript)] },
    { typeof(DMM.SubSuperscript), [typeof(DXM.SubSuperscript)] },
    { typeof(DMM.Superscript), [typeof(DXM.Superscript)] },
    { typeof(DMW.AltChunk), [typeof(DXW.AltChunk)] },
    { typeof(DMW.AnnotationReferenceMark), [typeof(DXW.AnnotationReferenceMark)] },
    { typeof(DMW.BidirectionalEmbedding), [typeof(DXW.BidirectionalEmbedding)] },
    { typeof(DMW.BidirectionalOverride), [typeof(DXW.BidirectionalOverride)] },
    { typeof(DMW.BookmarkEnd), [typeof(DXW.BookmarkEnd)] },
    { typeof(DMW.BookmarkStart), [typeof(DXW.BookmarkStart)] },
    { typeof(DMW.Break), [typeof(DXW.Break)] },
    { typeof(DMW.CarriageReturn), [typeof(DXW.CarriageReturn)] },
    { typeof(DMW.CommentRangeEnd), [typeof(DXW.CommentRangeEnd)] },
    { typeof(DMW.CommentRangeStart), [typeof(DXW.CommentRangeStart)] },
    { typeof(DMW.CommentReference), [typeof(DXW.CommentReference)] },
    { typeof(DMW.ContentPart), [typeof(DXW.ContentPart)] },
    { typeof(DMW.ContinuationSeparatorMark), [typeof(DXW.ContinuationSeparatorMark)] },
    { typeof(DMW.CustomXmlBlock), [typeof(DXW.CustomXmlBlock)] },
    { typeof(DMW.CustomXmlConflictDeletionRangeEnd), [typeof(DXO10W.CustomXmlConflictDeletionRangeEnd)] },
    { typeof(DMW.CustomXmlConflictDeletionRangeStart), [typeof(DXO10W.CustomXmlConflictDeletionRangeStart)] },
    { typeof(DMW.CustomXmlConflictInsertionRangeEnd), [typeof(DXO10W.CustomXmlConflictInsertionRangeEnd)] },
    { typeof(DMW.CustomXmlConflictInsertionRangeStart), [typeof(DXO10W.CustomXmlConflictInsertionRangeStart)] },
    { typeof(DMW.CustomXmlDelRangeEnd), [typeof(DXW.CustomXmlDelRangeEnd)] },
    { typeof(DMW.CustomXmlDelRangeStart), [typeof(DXW.CustomXmlDelRangeStart)] },
    { typeof(DMW.CustomXmlInsRangeEnd), [typeof(DXW.CustomXmlInsRangeEnd)] },
    { typeof(DMW.CustomXmlInsRangeStart), [typeof(DXW.CustomXmlInsRangeStart)] },
    { typeof(DMW.CustomXmlMoveFromRangeEnd), [typeof(DXW.CustomXmlMoveFromRangeEnd)] },
    { typeof(DMW.CustomXmlMoveFromRangeStart), [typeof(DXW.CustomXmlMoveFromRangeStart)] },
    { typeof(DMW.CustomXmlMoveToRangeEnd), [typeof(DXW.CustomXmlMoveToRangeEnd)] },
    { typeof(DMW.CustomXmlMoveToRangeStart), [typeof(DXW.CustomXmlMoveToRangeStart)] },
    { typeof(DMW.CustomXmlRun), [typeof(DXW.CustomXmlRun)] },
    { typeof(DMW.DayLong), [typeof(DXW.DayLong)] },
    { typeof(DMW.DayShort), [typeof(DXW.DayShort)] },
    { typeof(DMW.DeletedFieldCode), [typeof(DXW.DeletedFieldCode)] },
    { typeof(DMW.DeletedRun), [typeof(DXW.DeletedRun)] },
    { typeof(DMW.DeletedText), [typeof(DXW.DeletedText)] },
    { typeof(DMW.Drawing), [typeof(DXW.Drawing)] },
    { typeof(DMW.EmbeddedObject), [typeof(DXW.EmbeddedObject)] },
    { typeof(DMW.EndnoteReference), [typeof(DXW.EndnoteReference)] },
    { typeof(DMW.EndnoteReferenceMark), [typeof(DXW.EndnoteReferenceMark)] },
    { typeof(DMW.FieldChar), [typeof(DXW.FieldChar)] },
    { typeof(DMW.FootnoteReference), [typeof(DXW.FootnoteReference)] },
    { typeof(DMW.FootnoteReferenceMark), [typeof(DXW.FootnoteReferenceMark)] },
    { typeof(DMW.Hyperlink), [typeof(DXW.Hyperlink)] },
    { typeof(DMW.InsertedRun), [typeof(DXW.InsertedRun)] },
    { typeof(DMW.Languages), [typeof(DXW.Languages)]},
    { typeof(DMW.LastRenderedPageBreak), [typeof(DXW.LastRenderedPageBreak)] },
    { typeof(DMW.MonthLong), [typeof(DXW.MonthLong)] },
    { typeof(DMW.MonthShort), [typeof(DXW.MonthShort)] },
    { typeof(DMW.MoveFromRangeEnd), [typeof(DXW.MoveFromRangeEnd)] },
    { typeof(DMW.MoveFromRangeStart), [typeof(DXW.MoveFromRangeStart)] },
    { typeof(DMW.MoveFromRun), [typeof(DXW.MoveFromRun)] },
    { typeof(DMW.MoveToRangeEnd), [typeof(DXW.MoveToRangeEnd)] },
    { typeof(DMW.MoveToRangeStart), [typeof(DXW.MoveToRangeStart)] },
    { typeof(DMW.MoveToRun), [typeof(DXW.MoveToRun)] },
    { typeof(DMW.NoBreakHyphen), [typeof(DXW.NoBreakHyphen)] },
    { typeof(DMW.PageNumber), [typeof(DXW.PageNumber)] },
    { typeof(DMW.Paragraph), [typeof(DXW.Paragraph)] },
    { typeof(DMW.ParagraphProperties), [typeof(DXW.ParagraphProperties)] },
    { typeof(DMW.PermEnd), [typeof(DXW.PermEnd)] },
    { typeof(DMW.PermStart), [typeof(DXW.PermStart)] },
    { typeof(DMW.Picture), [typeof(DXW.Picture)] },
    { typeof(DMW.PositionalTab), [typeof(DXW.PositionalTab)] },
    { typeof(DMW.ProofError), [typeof(DXW.ProofError)] },
    { typeof(DMW.Ruby), [typeof(DXW.Ruby)] },
    { typeof(DMW.Run), [typeof(DXW.Run)] },
    { typeof(DMW.RunConflictDeletion), [typeof(DXO10W.RunConflictDeletion)] },
    { typeof(DMW.RunConflictInsertion), [typeof(DXO10W.RunConflictInsertion)] },
    { typeof(DMW.RunProperties), [typeof(DXW.RunProperties)] },
    { typeof(DMW.RunText), [typeof(DXW.Text)] },
    { typeof(DMW.SdtBlock), [typeof(DXW.SdtBlock)] },
    { typeof(DMW.SdtRun), [typeof(DXW.SdtRun)] },
    { typeof(DMW.SectionProperties), [typeof(DXW.SectionProperties)] },
    { typeof(DMW.SeparatorMark), [typeof(DXW.SeparatorMark)] },
    { typeof(DMW.SimpleField), [typeof(DXW.SimpleField)] },
    { typeof(DMW.SoftHyphen), [typeof(DXW.SoftHyphen)] },
    { typeof(DMW.SubDocumentReference), [typeof(DXW.SubDocumentReference)] },
    { typeof(DMW.SymbolChar), [typeof(DXW.SymbolChar)] },
    { typeof(DMW.TabChar), [typeof(DXW.TabChar)] },
    { typeof(DMW.Table), [typeof(DXW.Table)] },
    { typeof(DMW.YearLong), [typeof(DXW.YearLong)] },
    { typeof(DMW.YearShort), [typeof(DXW.YearShort)] },
  };
}