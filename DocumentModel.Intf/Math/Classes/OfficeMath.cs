using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies an instance of mathematical text. 
///   When used independently (not inside an oMathPara) with non-mathematical text preceding and/or following it, 
///   an independent oMath is interpreted as an inline math zone. 
///   All such math zones, including equations, expressions, 
///   arrays of equations or expressions and formulas are represented by oMath blocks. 
///   When used in a display math zone (a math paragraph, oMathPara), 
///   oMath is a container for an instance of mathematical text 
///   that starts on its own line and is not an inline math zone. 
///   When an oMath block is part of a display math zone, it is not itself an inline math zone. 
///   When an oMath block is not part of a display math zone, it is interpreted as its own inline math zone. 
///   The contents of an oMath block do not differ between display zone containers and independent inline math zones.
/// </summary>
public class OfficeMath: ElementCollection<IOfficeMathContent>, ICommonMathContent, IMathParagraphContent
{
}