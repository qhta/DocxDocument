namespace DocumentModel.Math;

/// <summary>
///   This element specifies whether there is a line break at the start of a run, or at the start of the Box object, 
///   such that the line wraps at the start of the run or box object. 
///   These user-defined line breaks occur when the XML tag &lt;m:brk/&gt; is encountered 
///   and does not follow a mathematical "order of precedence". 
///   If this element is omitted, a manual break is not inserted. 
///   In other words, when the element is absent, the default is for the parent structure to not manually break onto the next line. 
///   When the element is present and the val attribute is absent, the default of the val attribute is 0 
///   meaning that this property’s parent structure manually breaks onto the next line and is aligned with the beginning of the previous line. 
/// </summary>
public class Break: ModelElement
{
  /// <summary>
  ///   Specifies the index of the operator on the previous line of mathematical text which shall be used 
  ///   as the alignment point for the current line of mathematical text . 
  ///   A line can be aligned to any operator on the previous line; 
  ///   this attribute specifies exactly which operator shall be the target of that alignment in cases where there are multiple operators. 
  ///   If alnAt is omitted, then all runs (r tag) that follow a brk tag will align with the left margin of the first run of mathematical text.
  /// </summary>
  public Int32? AlignAt { get; set; }

}