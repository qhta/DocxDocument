namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Matrix object, consisting of one or more elements laid out in one or more rows and one or more columns. 
///   It is important to note that matrices do not have built in delimiters. 
///   Like other math elements, matrices are contained in a delimiter object (§22.1.2.24) when delimiters are desired. 
///   Empty arguments (see §22.1.2.32) can be used to create gaps in matrices. 
///   The plcHide tag (§22.1.2.83) can be used to indicate whether the empty arguments should be visible in the matrix 
///   (see the plcHide documentation for more information). 
/// </summary>
public class Matrix: ElementCollection<MatrixRow>, ICommonMathContent
{
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get; set; }
}