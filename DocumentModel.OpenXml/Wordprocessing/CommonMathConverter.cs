namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for common markers: 
/// ProofError, PermStart/PermEnd, BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd, 
/// InsertedRun, DeletedRun, MoveFromRun, MoveToRun, RunConflictInsertion, RunConflictDeletion converter from/to OpenXml.
///</summary>
public static class CommonMathConverter
{
  public static DMMath.ICommonMathElement? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXMath.Paragraph paragraph)
      return DMXMath.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXMath.OfficeMath officeMath)
      return DMXMath.OfficeMathConverter.CreateModelElement(officeMath);
    if (openXmlElement is DXMath.Accent accent)
      return DMXMath.AccentConverter.CreateModelElement(accent);
    if (openXmlElement is DXMath.Bar bar)
      return DMXMath.BarConverter.CreateModelElement(bar);
    if (openXmlElement is DXMath.Box box)
      return DMXMath.BoxConverter.CreateModelElement(box);
    if (openXmlElement is DXMath.BorderBox borderBox)
      return DMXMath.BorderBoxConverter.CreateModelElement(borderBox);
    if (openXmlElement is DXMath.Delimiter delimiter)
      return DMXMath.DelimiterConverter.CreateModelElement(delimiter);
    if (openXmlElement is DXMath.EquationArray equationArray)
      return DMXMath.EquationArrayConverter.CreateModelElement(equationArray);
    if (openXmlElement is DXMath.Fraction fraction)
      return DMXMath.FractionConverter.CreateModelElement(fraction);
    if (openXmlElement is DXMath.MathFunction mathFunction)
      return DMXMath.MathFunctionConverter.CreateModelElement(mathFunction);
    if (openXmlElement is DXMath.GroupChar groupChar)
      return DMXMath.GroupCharConverter.CreateModelElement(groupChar);
    if (openXmlElement is DXMath.LimitLower limitLower)
      return DMXMath.LimitLowerConverter.CreateModelElement(limitLower);
    if (openXmlElement is DXMath.LimitUpper limitUpper)
      return DMXMath.LimitUpperConverter.CreateModelElement(limitUpper);
    if (openXmlElement is DXMath.Matrix matrix)
      return DMXMath.MatrixConverter.CreateModelElement(matrix);
    if (openXmlElement is DXMath.Nary nary)
      return DMXMath.NaryConverter.CreateModelElement(nary);
    if (openXmlElement is DXMath.Phantom phantom)
      return DMXMath.PhantomConverter.CreateModelElement(phantom);
    if (openXmlElement is DXMath.Radical radical)
      return DMXMath.RadicalConverter.CreateModelElement(radical);
    if (openXmlElement is DXMath.PreSubSuper preSubSuper)
      return DMXMath.PreSubSuperConverter.CreateModelElement(preSubSuper);
    if (openXmlElement is DXMath.Subscript subscript)
      return DMXMath.SubscriptConverter.CreateModelElement(subscript);
    if (openXmlElement is DXMath.SubSuperscript subSuperscript)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(subSuperscript);
    if (openXmlElement is DXMath.Superscript superscript)
      return DMXMath.SuperscriptConverter.CreateModelElement(superscript);

    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMMath.ICommonMathElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXMath.Paragraph paragraph && value is DMMath.Paragraph paragraphModel)
        return DMXMath.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXMath.OfficeMath officeMath && value is DMMath.OfficeMath officeMathModel)
        return DMXMath.OfficeMathConverter.CompareModelElement(officeMath, officeMathModel, diffs, objName);
      if (openXmlElement is DXMath.Accent accent && value is DMMath.Accent accentModel)
        return DMXMath.AccentConverter.CompareModelElement(accent, accentModel, diffs, objName);
      if (openXmlElement is DXMath.Bar bar && value is DMMath.Bar barModel)
        return DMXMath.BarConverter.CompareModelElement(bar, barModel, diffs, objName);
      if (openXmlElement is DXMath.Box box && value is DMMath.Box boxModel)
        return DMXMath.BoxConverter.CompareModelElement(box, boxModel, diffs, objName);
      if (openXmlElement is DXMath.BorderBox borderBox && value is DMMath.BorderBox borderBoxModel)
        return DMXMath.BorderBoxConverter.CompareModelElement(borderBox, borderBoxModel, diffs, objName);
      if (openXmlElement is DXMath.Delimiter delimiter && value is DMMath.Delimiter delimiterModel)
        return DMXMath.DelimiterConverter.CompareModelElement(delimiter, delimiterModel, diffs, objName);
      if (openXmlElement is DXMath.EquationArray equationArray && value is DMMath.EquationArray equationArrayModel)
        return DMXMath.EquationArrayConverter.CompareModelElement(equationArray, equationArrayModel, diffs, objName);
      if (openXmlElement is DXMath.Fraction fraction && value is DMMath.Fraction fractionModel)
        return DMXMath.FractionConverter.CompareModelElement(fraction, fractionModel, diffs, objName);
      if (openXmlElement is DXMath.MathFunction mathFunction && value is DMMath.MathFunction mathFunctionModel)
        return DMXMath.MathFunctionConverter.CompareModelElement(mathFunction, mathFunctionModel, diffs, objName);
      if (openXmlElement is DXMath.GroupChar groupChar && value is DMMath.GroupChar groupCharModel)
        return DMXMath.GroupCharConverter.CompareModelElement(groupChar, groupCharModel, diffs, objName);
      if (openXmlElement is DXMath.LimitLower limitLower && value is DMMath.LimitLower limitLowerModel)
        return DMXMath.LimitLowerConverter.CompareModelElement(limitLower, limitLowerModel, diffs, objName);
      if (openXmlElement is DXMath.LimitUpper limitUpper && value is DMMath.LimitUpper limitUpperModel)
        return DMXMath.LimitUpperConverter.CompareModelElement(limitUpper, limitUpperModel, diffs, objName);
      if (openXmlElement is DXMath.Matrix matrix && value is DMMath.Matrix matrixModel)
        return DMXMath.MatrixConverter.CompareModelElement(matrix, matrixModel, diffs, objName);
      if (openXmlElement is DXMath.Nary nary && value is DMMath.Nary naryModel)
        return DMXMath.NaryConverter.CompareModelElement(nary, naryModel, diffs, objName);
      if (openXmlElement is DXMath.Phantom phantom && value is DMMath.Phantom phantomModel)
        return DMXMath.PhantomConverter.CompareModelElement(phantom, phantomModel, diffs, objName);
      if (openXmlElement is DXMath.Radical radical && value is DMMath.Radical radicalModel)
        return DMXMath.RadicalConverter.CompareModelElement(radical, radicalModel, diffs, objName);
      if (openXmlElement is DXMath.PreSubSuper preSubSuper && value is DMMath.PreSubSuper preSubSuperModel)
        return DMXMath.PreSubSuperConverter.CompareModelElement(preSubSuper, preSubSuperModel, diffs, objName);
      if (openXmlElement is DXMath.Subscript subscript && value is DMMath.Subscript subscriptModel)
        return DMXMath.SubscriptConverter.CompareModelElement(subscript, subscriptModel, diffs, objName);
      if (openXmlElement is DXMath.SubSuperscript subSuperscript && value is DMMath.SubSuperscript subSuperscriptModel)
        return DMXMath.SubSuperscriptConverter.CompareModelElement(subSuperscript, subSuperscriptModel, diffs, objName);
      if (openXmlElement is DXMath.Superscript superscript && value is DMMath.Superscript superscriptModel)
        return DMXMath.SuperscriptConverter.CompareModelElement(superscript, superscriptModel, diffs, objName);
      return null;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMMath.ICommonMathElement? value)
  {
    if (value is DMMath.Paragraph paragraph)
      return DMXMath.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMMath.OfficeMath officeMath)
      return DMXMath.OfficeMathConverter.CreateOpenXmlElement(officeMath);
    if (value is DMMath.Accent accent)
      return DMXMath.AccentConverter.CreateOpenXmlElement(accent);
    if (value is DMMath.Bar bar)
      return DMXMath.BarConverter.CreateOpenXmlElement(bar);
    if (value is DMMath.Box box)
      return DMXMath.BoxConverter.CreateOpenXmlElement(box);
    if (value is DMMath.BorderBox borderBox)
      return DMXMath.BorderBoxConverter.CreateOpenXmlElement(borderBox);
    if (value is DMMath.Delimiter delimiter)
      return DMXMath.DelimiterConverter.CreateOpenXmlElement(delimiter);
    if (value is DMMath.EquationArray equationArray)
      return DMXMath.EquationArrayConverter.CreateOpenXmlElement(equationArray);
    if (value is DMMath.Fraction fraction)
      return DMXMath.FractionConverter.CreateOpenXmlElement(fraction);
    if (value is DMMath.MathFunction mathFunction)
      return DMXMath.MathFunctionConverter.CreateOpenXmlElement(mathFunction);
    if (value is DMMath.GroupChar groupChar)
      return DMXMath.GroupCharConverter.CreateOpenXmlElement(groupChar);
    if (value is DMMath.LimitLower limitLower)
      return DMXMath.LimitLowerConverter.CreateOpenXmlElement(limitLower);
    if (value is DMMath.LimitUpper limitUpper)
      return DMXMath.LimitUpperConverter.CreateOpenXmlElement(limitUpper);
    if (value is DMMath.Matrix matrix)
      return DMXMath.MatrixConverter.CreateOpenXmlElement(matrix);
    if (value is DMMath.Nary nary)
      return DMXMath.NaryConverter.CreateOpenXmlElement(nary);
    if (value is DMMath.Phantom phantom)
      return DMXMath.PhantomConverter.CreateOpenXmlElement(phantom);
    if (value is DMMath.Radical radical)
      return DMXMath.RadicalConverter.CreateOpenXmlElement(radical);
    if (value is DMMath.PreSubSuper preSubSuper)
      return DMXMath.PreSubSuperConverter.CreateOpenXmlElement(preSubSuper);
    if (value is DMMath.Subscript subscript)
      return DMXMath.SubscriptConverter.CreateOpenXmlElement(subscript);
    if (value is DMMath.SubSuperscript subSuperscript)
      return DMXMath.SubSuperscriptConverter.CreateOpenXmlElement(subSuperscript);
    if (value is DMMath.Superscript superscript)
      return DMXMath.SuperscriptConverter.CreateOpenXmlElement(superscript);

    return null;
  }

    public static bool? UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DMMath.ICommonMathElement? value)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXMath.Paragraph paragraph && value is DMMath.Paragraph paragraphModel)
        return DMXMath.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
      if (openXmlElement is DXMath.OfficeMath officeMath && value is DMMath.OfficeMath officeMathModel)
        return DMXMath.OfficeMathConverter.UpdateOpenXmlElement(officeMath, officeMathModel);
      if (openXmlElement is DXMath.Accent accent && value is DMMath.Accent accentModel)
        return DMXMath.AccentConverter.UpdateOpenXmlElement(accent, accentModel);
      if (openXmlElement is DXMath.Bar bar && value is DMMath.Bar barModel)
        return DMXMath.BarConverter.UpdateOpenXmlElement(bar, barModel);
      if (openXmlElement is DXMath.Box box && value is DMMath.Box boxModel)
        return DMXMath.BoxConverter.UpdateOpenXmlElement(box, boxModel);
      if (openXmlElement is DXMath.BorderBox borderBox && value is DMMath.BorderBox borderBoxModel)
        return DMXMath.BorderBoxConverter.UpdateOpenXmlElement(borderBox, borderBoxModel);
      if (openXmlElement is DXMath.Delimiter delimiter && value is DMMath.Delimiter delimiterModel)
        return DMXMath.DelimiterConverter.UpdateOpenXmlElement(delimiter, delimiterModel);
      if (openXmlElement is DXMath.EquationArray equationArray && value is DMMath.EquationArray equationArrayModel)
        return DMXMath.EquationArrayConverter.UpdateOpenXmlElement(equationArray, equationArrayModel);
      if (openXmlElement is DXMath.Fraction fraction && value is DMMath.Fraction fractionModel)
        return DMXMath.FractionConverter.UpdateOpenXmlElement(fraction, fractionModel);
      if (openXmlElement is DXMath.MathFunction mathFunction && value is DMMath.MathFunction mathFunctionModel)
        return DMXMath.MathFunctionConverter.UpdateOpenXmlElement(mathFunction, mathFunctionModel);
      if (openXmlElement is DXMath.GroupChar groupChar && value is DMMath.GroupChar groupCharModel)
        return DMXMath.GroupCharConverter.UpdateOpenXmlElement(groupChar, groupCharModel);
      if (openXmlElement is DXMath.LimitLower limitLower && value is DMMath.LimitLower limitLowerModel)
        return DMXMath.LimitLowerConverter.UpdateOpenXmlElement(limitLower, limitLowerModel);
      if (openXmlElement is DXMath.LimitUpper limitUpper && value is DMMath.LimitUpper limitUpperModel)
        return DMXMath.LimitUpperConverter.UpdateOpenXmlElement(limitUpper, limitUpperModel);
      if (openXmlElement is DXMath.Matrix matrix && value is DMMath.Matrix matrixModel)
        return DMXMath.MatrixConverter.UpdateOpenXmlElement(matrix, matrixModel);
      if (openXmlElement is DXMath.Nary nary && value is DMMath.Nary naryModel)
        return DMXMath.NaryConverter.UpdateOpenXmlElement(nary, naryModel);
      if (openXmlElement is DXMath.Phantom phantom && value is DMMath.Phantom phantomModel)
        return DMXMath.PhantomConverter.UpdateOpenXmlElement(phantom, phantomModel);
      if (openXmlElement is DXMath.Radical radical && value is DMMath.Radical radicalModel)
        return DMXMath.RadicalConverter.UpdateOpenXmlElement(radical, radicalModel);
      if (openXmlElement is DXMath.PreSubSuper preSubSuper && value is DMMath.PreSubSuper preSubSuperModel)
        return DMXMath.PreSubSuperConverter.UpdateOpenXmlElement(preSubSuper, preSubSuperModel);
      if (openXmlElement is DXMath.Subscript subscript && value is DMMath.Subscript subscriptModel)
        return DMXMath.SubscriptConverter.UpdateOpenXmlElement(subscript, subscriptModel);
      if (openXmlElement is DXMath.SubSuperscript subSuperscript && value is DMMath.SubSuperscript subSuperscriptModel)
        return DMXMath.SubSuperscriptConverter.UpdateOpenXmlElement(subSuperscript, subSuperscriptModel);
      if (openXmlElement is DXMath.Superscript superscript && value is DMMath.Superscript superscriptModel)
        return DMXMath.SuperscriptConverter.UpdateOpenXmlElement(superscript, superscriptModel);
    }
    return false;
  }

}
