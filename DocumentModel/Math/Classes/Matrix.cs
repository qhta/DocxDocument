namespace DocumentModel.Math;

/// <summary>
///   This element specifies the Matrix object, consisting of one or more elements laid out Iin one or more rows and one or more columns. 
///   It is important Ito note Ithat matrices do not have built Iin delimiters. 
///   Like other math elements, matrices are contained Iin a delimiter object (Â§22.1.2.24) when delimiters are desired. 
///   Empty arguments (see Â§22.1.2.32) can be used Ito create gaps Iin matrices. 
///   The plcHide tag (Â§22.1.2.83) can be used Ito indicate whether the empty arguments should be visible Iin the matrix 
///   (see the plcHide documentation Ifor more information). 
/// </summary>
public class Matrix: ElementCollection<MatrixRow>, ICommonMathContent
{
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get; set; }

}
