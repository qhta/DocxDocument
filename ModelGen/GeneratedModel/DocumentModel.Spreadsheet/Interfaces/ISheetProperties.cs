namespace DocumentModel.Spreadsheet;

public interface ISheetProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? SyncHorizontal { get ; set; }

  public bool? SyncVertical { get ; set; }

  public string? SyncReference { get ; set; }

  public bool? TransitionEvaluation { get ; set; }

  public bool? TransitionEntry { get ; set; }

  public bool? Published { get ; set; }

  public string? CodeName { get ; set; }

  public bool? FilterMode { get ; set; }

  public bool? EnableFormatConditionsCalculation { get ; set; }

  public ITabColor? TabColor { get ; set; }

  public IOutlineProperties? OutlineProperties { get ; set; }

  public IPageSetupProperties? PageSetupProperties { get ; set; }

}
