namespace DocumentModel.Spreadsheet.Vml;

/// <summary>
/// Attached Object Data.
/// </summary>
public interface IClientData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Object type
  /// </summary>
  public ObjectKind? ObjectType { get ; set; }
  
  public Collection<String>? MoveWithCellses { get ; set; }
  
  public Collection<String>? ResizeWithCellses { get ; set; }
  
  public Collection<String>? Anchors { get ; set; }
  
  public Collection<String>? Lockeds { get ; set; }
  
  public Collection<String>? DefaultSizes { get ; set; }
  
  public Collection<String>? PrintObjects { get ; set; }
  
  public Collection<String>? Disableds { get ; set; }
  
  public Collection<String>? AutoFills { get ; set; }
  
  public Collection<String>? AutoLines { get ; set; }
  
  public Collection<String>? AutoSizePictures { get ; set; }
  
  public Collection<String>? FormulaMacros { get ; set; }
  
  public Collection<String>? HorizontalTextAlignments { get ; set; }
  
  public Collection<String>? VerticalTextAlignments { get ; set; }
  
  public Collection<String>? LockTexts { get ; set; }
  
  public Collection<String>? JustifyLastLines { get ; set; }
  
  public Collection<String>? SecretEdits { get ; set; }
  
  public Collection<String>? DefaultButtons { get ; set; }
  
  public Collection<String>? HelpButtons { get ; set; }
  
  public Collection<String>? CancelButtons { get ; set; }
  
  public Collection<String>? DismissButtons { get ; set; }
  
  public Collection<String>? AcceleratorPrimaries { get ; set; }
  
  public Collection<String>? AcceleratorSecondaries { get ; set; }
  
  public Collection<String>? CommentRowTargets { get ; set; }
  
  public Collection<String>? CommentColumnTargets { get ; set; }
  
  public Collection<String>? Visibles { get ; set; }
  
  public Collection<String>? RowHiddens { get ; set; }
  
  public Collection<String>? ColumnHiddens { get ; set; }
  
  public Collection<String>? InputValidationTypes { get ; set; }
  
  public Collection<String>? MultiLines { get ; set; }
  
  public Collection<String>? VerticalScrollBars { get ; set; }
  
  public Collection<String>? ValidIdses { get ; set; }
  
  public Collection<String>? FormulaRanges { get ; set; }
  
  public Collection<String>? MinDropDownWidths { get ; set; }
  
  public Collection<String>? SelectionEntries { get ; set; }
  
  public Collection<String>? Disable3DForListBoxAndDropDowns { get ; set; }
  
  public Collection<String>? SelectionTypes { get ; set; }
  
  public Collection<String>? MultiSelectionses { get ; set; }
  
  public Collection<String>? ListBoxCallbackTypes { get ; set; }
  
  public Collection<String>? ListItems { get ; set; }
  
  public Collection<String>? DropStyles { get ; set; }
  
  public Collection<String>? Coloreds { get ; set; }
  
  public Collection<String>? DropLineses { get ; set; }
  
  public Collection<String>? Checkeds { get ; set; }
  
  public Collection<String>? FormulaLinks { get ; set; }
  
  public Collection<String>? FormulaPictures { get ; set; }
  
  public Collection<String>? Disable3Ds { get ; set; }
  
  public Collection<String>? FirstButtons { get ; set; }
  
  public Collection<String>? FormulaGroups { get ; set; }
  
  public Collection<String>? ScrollBarPositions { get ; set; }
  
  public Collection<String>? ScrollBarMins { get ; set; }
  
  public Collection<String>? ScrollBarMaxs { get ; set; }
  
  public Collection<String>? ScrollBarIncrements { get ; set; }
  
  public Collection<String>? ScrollBarPageIncrements { get ; set; }
  
  public Collection<String>? HorizontalScrollBars { get ; set; }
  
  public Collection<String>? ScrollBarWidths { get ; set; }
  
  public Collection<String>? MapOcxControls { get ; set; }
  
  public Collection<String>? ClipboardFormats { get ; set; }
  
  public Collection<String>? CameraObjects { get ; set; }
  
  public Collection<String>? RecalculateAlwayses { get ; set; }
  
  public Collection<String>? AutoScaleFonts { get ; set; }
  
  public Collection<String>? DdeObjects { get ; set; }
  
  public Collection<String>? UIObjects { get ; set; }
  
  public Collection<String>? ScriptTexts { get ; set; }
  
  public Collection<String>? ScriptExtendeds { get ; set; }
  
  public Collection<String>? ScriptLanguages { get ; set; }
  
  public Collection<String>? ScriptLocations { get ; set; }
  
  public Collection<String>? FormulaTextBoxs { get ; set; }
  
}
