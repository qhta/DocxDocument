namespace DocumentModel.Office2016.Excel;

public interface IDataValidation // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DataValidation? Type { get ; set; }

  public DataValidationErrorStyle? ErrorStyle { get ; set; }

  public DataValidationImeMode? ImeMode { get ; set; }

  public DataValidationOperator? Operator { get ; set; }

  public bool? AllowBlank { get ; set; }

  public bool? ShowDropDown { get ; set; }

  public bool? ShowInputMessage { get ; set; }

  public bool? ShowErrorMessage { get ; set; }

  public string? ErrorTitle { get ; set; }

  public string? Error { get ; set; }

  public string? PromptTitle { get ; set; }

  public string? Prompt { get ; set; }

  public List<string>? SequenceOfReferences { get ; set; }

  public string? List { get ; set; }

  public IFormula1? Formula1 { get ; set; }

  public IFormula2? Formula2 { get ; set; }

}
