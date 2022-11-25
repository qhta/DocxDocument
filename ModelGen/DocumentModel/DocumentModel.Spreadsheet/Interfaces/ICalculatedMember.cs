namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Member.
/// </summary>
public interface ICalculatedMember // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// mdx
  /// </summary>
  public System.String? Mdx { get ; set; }
  
  /// <summary>
  /// memberName
  /// </summary>
  public System.String? MemberName { get ; set; }
  
  /// <summary>
  /// hierarchy
  /// </summary>
  public System.String? Hierarchy { get ; set; }
  
  /// <summary>
  /// parent
  /// </summary>
  public System.String? ParentName { get ; set; }
  
  /// <summary>
  /// solveOrder
  /// </summary>
  public System.Int32? SolveOrder { get ; set; }
  
  /// <summary>
  /// set
  /// </summary>
  public System.Boolean? Set { get ; set; }
  
  /// <summary>
  /// CalculatedMemberExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CalculatedMemberExtensionList { get ; set; }
  
}
