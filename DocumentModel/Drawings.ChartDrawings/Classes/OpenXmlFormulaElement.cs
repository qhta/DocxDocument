namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the OpenXmlFormulaElement Class.
/// </summary>
public class OpenXmlFormulaElement: ModelElement
{
  /// <summary>
  ///   dir, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public FormulaDirection? Dir { get; set; }
}
