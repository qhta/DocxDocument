namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines conversion method for common markers: 
/// ProofError, PermStart/PermEnd, BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd, 
/// InsertedRun, DeletedRun, MoveFromRun, MoveToRun, RunConflictInsertion, RunConflictDeletion.
/// </summary>
public static class CommonMathConverter
{
  public static DMM.ICommonMathContent? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXM.Paragraph paragraph)
      return DMXM.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXM.OfficeMath officeMath)
      return DMXM.OfficeMathConverter.CreateModelElement(officeMath);
    if (openXmlElement is DXM.Accent accent)
      return DMXM.AccentConverter.CreateModelElement(accent);
    if (openXmlElement is DXM.Bar bar)
      return DMXM.BarConverter.CreateModelElement(bar);
    if (openXmlElement is DXM.Box box)
      return DMXM.BoxConverter.CreateModelElement(box);
    if (openXmlElement is DXM.BorderBox borderBox)
      return DMXM.BorderBoxConverter.CreateModelElement(borderBox);
    if (openXmlElement is DXM.Delimiter delimiter)
      return DMXM.DelimiterConverter.CreateModelElement(delimiter);
    if (openXmlElement is DXM.EquationArray equationArray)
      return DMXM.EquationArrayConverter.CreateModelElement(equationArray);
    if (openXmlElement is DXM.Fraction fraction)
      return DMXM.FractionConverter.CreateModelElement(fraction);
    if (openXmlElement is DXM.MathFunction mathFunction)
      return DMXM.MathFunctionConverter.CreateModelElement(mathFunction);
    if (openXmlElement is DXM.GroupChar groupChar)
      return DMXM.GroupCharConverter.CreateModelElement(groupChar);
    if (openXmlElement is DXM.LimitLower limitLower)
      return DMXM.LimitLowerConverter.CreateModelElement(limitLower);
    if (openXmlElement is DXM.LimitUpper limitUpper)
      return DMXM.LimitUpperConverter.CreateModelElement(limitUpper);
    if (openXmlElement is DXM.Matrix matrix)
      return DMXM.MatrixConverter.CreateModelElement(matrix);
    if (openXmlElement is DXM.Nary nary)
      return DMXM.NaryConverter.CreateModelElement(nary);
    if (openXmlElement is DXM.Phantom phantom)
      return DMXM.PhantomConverter.CreateModelElement(phantom);
    if (openXmlElement is DXM.Radical radical)
      return DMXM.RadicalConverter.CreateModelElement(radical);
    if (openXmlElement is DXM.PreSubSuper preSubSuper)
      return DMXM.PreSubSuperConverter.CreateModelElement(preSubSuper);
    if (openXmlElement is DXM.Subscript subscript)
      return DMXM.SubscriptConverter.CreateModelElement(subscript);
    if (openXmlElement is DXM.SubSuperscript subSuperscript)
      return DMXM.SubSuperscriptConverter.CreateModelElement(subSuperscript);
    if (openXmlElement is DXM.Superscript superscript)
      return DMXM.SuperscriptConverter.CreateModelElement(superscript);

    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMM.ICommonMathContent? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXM.Paragraph paragraph && value is DMM.Paragraph paragraphModel)
        return DMXM.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXM.OfficeMath officeMath && value is DMM.OfficeMath officeMathModel)
        return DMXM.OfficeMathConverter.CompareModelElement(officeMath, officeMathModel, diffs, objName);
      if (openXmlElement is DXM.Accent accent && value is DMM.Accent accentModel)
        return DMXM.AccentConverter.CompareModelElement(accent, accentModel, diffs, objName);
      if (openXmlElement is DXM.Bar bar && value is DMM.Bar barModel)
        return DMXM.BarConverter.CompareModelElement(bar, barModel, diffs, objName);
      if (openXmlElement is DXM.Box box && value is DMM.Box boxModel)
        return DMXM.BoxConverter.CompareModelElement(box, boxModel, diffs, objName);
      if (openXmlElement is DXM.BorderBox borderBox && value is DMM.BorderBox borderBoxModel)
        return DMXM.BorderBoxConverter.CompareModelElement(borderBox, borderBoxModel, diffs, objName);
      if (openXmlElement is DXM.Delimiter delimiter && value is DMM.Delimiter delimiterModel)
        return DMXM.DelimiterConverter.CompareModelElement(delimiter, delimiterModel, diffs, objName);
      if (openXmlElement is DXM.EquationArray equationArray && value is DMM.EquationArray equationArrayModel)
        return DMXM.EquationArrayConverter.CompareModelElement(equationArray, equationArrayModel, diffs, objName);
      if (openXmlElement is DXM.Fraction fraction && value is DMM.Fraction fractionModel)
        return DMXM.FractionConverter.CompareModelElement(fraction, fractionModel, diffs, objName);
      if (openXmlElement is DXM.MathFunction mathFunction && value is DMM.Function mathFunctionModel)
        return DMXM.MathFunctionConverter.CompareModelElement(mathFunction, mathFunctionModel, diffs, objName);
      if (openXmlElement is DXM.GroupChar groupChar && value is DMM.GroupChar groupCharModel)
        return DMXM.GroupCharConverter.CompareModelElement(groupChar, groupCharModel, diffs, objName);
      if (openXmlElement is DXM.LimitLower limitLower && value is DMM.LimitLower limitLowerModel)
        return DMXM.LimitLowerConverter.CompareModelElement(limitLower, limitLowerModel, diffs, objName);
      if (openXmlElement is DXM.LimitUpper limitUpper && value is DMM.LimitUpper limitUpperModel)
        return DMXM.LimitUpperConverter.CompareModelElement(limitUpper, limitUpperModel, diffs, objName);
      if (openXmlElement is DXM.Matrix matrix && value is DMM.Matrix matrixModel)
        return DMXM.MatrixConverter.CompareModelElement(matrix, matrixModel, diffs, objName);
      if (openXmlElement is DXM.Nary nary && value is DMM.Nary naryModel)
        return DMXM.NaryConverter.CompareModelElement(nary, naryModel, diffs, objName);
      if (openXmlElement is DXM.Phantom phantom && value is DMM.Phantom phantomModel)
        return DMXM.PhantomConverter.CompareModelElement(phantom, phantomModel, diffs, objName);
      if (openXmlElement is DXM.Radical radical && value is DMM.Radical radicalModel)
        return DMXM.RadicalConverter.CompareModelElement(radical, radicalModel, diffs, objName);
      if (openXmlElement is DXM.PreSubSuper preSubSuper && value is DMM.PreSubSuper preSubSuperModel)
        return DMXM.PreSubSuperConverter.CompareModelElement(preSubSuper, preSubSuperModel, diffs, objName);
      if (openXmlElement is DXM.Subscript subscript && value is DMM.Subscript subscriptModel)
        return DMXM.SubscriptConverter.CompareModelElement(subscript, subscriptModel, diffs, objName);
      if (openXmlElement is DXM.SubSuperscript subSuperscript && value is DMM.SubSuperscript subSuperscriptModel)
        return DMXM.SubSuperscriptConverter.CompareModelElement(subSuperscript, subSuperscriptModel, diffs, objName);
      if (openXmlElement is DXM.Superscript superscript && value is DMM.Superscript superscriptModel)
        return DMXM.SuperscriptConverter.CompareModelElement(superscript, superscriptModel, diffs, objName);
      return null;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMM.ICommonMathContent? value)
  {
    if (value is DMM.Paragraph paragraph)
      return DMXM.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMM.OfficeMath officeMath)
      return DMXM.OfficeMathConverter.CreateOpenXmlElement(officeMath);
    if (value is DMM.Accent accent)
      return DMXM.AccentConverter.CreateOpenXmlElement(accent);
    if (value is DMM.Bar bar)
      return DMXM.BarConverter.CreateOpenXmlElement(bar);
    if (value is DMM.Box box)
      return DMXM.BoxConverter.CreateOpenXmlElement(box);
    if (value is DMM.BorderBox borderBox)
      return DMXM.BorderBoxConverter.CreateOpenXmlElement(borderBox);
    if (value is DMM.Delimiter delimiter)
      return DMXM.DelimiterConverter.CreateOpenXmlElement(delimiter);
    if (value is DMM.EquationArray equationArray)
      return DMXM.EquationArrayConverter.CreateOpenXmlElement(equationArray);
    if (value is DMM.Fraction fraction)
      return DMXM.FractionConverter.CreateOpenXmlElement(fraction);
    if (value is DMM.Function mathFunction)
      return DMXM.MathFunctionConverter.CreateOpenXmlElement(mathFunction);
    if (value is DMM.GroupChar groupChar)
      return DMXM.GroupCharConverter.CreateOpenXmlElement(groupChar);
    if (value is DMM.LimitLower limitLower)
      return DMXM.LimitLowerConverter.CreateOpenXmlElement(limitLower);
    if (value is DMM.LimitUpper limitUpper)
      return DMXM.LimitUpperConverter.CreateOpenXmlElement(limitUpper);
    if (value is DMM.Matrix matrix)
      return DMXM.MatrixConverter.CreateOpenXmlElement(matrix);
    if (value is DMM.Nary nary)
      return DMXM.NaryConverter.CreateOpenXmlElement(nary);
    if (value is DMM.Phantom phantom)
      return DMXM.PhantomConverter.CreateOpenXmlElement(phantom);
    if (value is DMM.Radical radical)
      return DMXM.RadicalConverter.CreateOpenXmlElement(radical);
    if (value is DMM.PreSubSuper preSubSuper)
      return DMXM.PreSubSuperConverter.CreateOpenXmlElement(preSubSuper);
    if (value is DMM.Subscript subscript)
      return DMXM.SubscriptConverter.CreateOpenXmlElement(subscript);
    if (value is DMM.SubSuperscript subSuperscript)
      return DMXM.SubSuperscriptConverter.CreateOpenXmlElement(subSuperscript);
    if (value is DMM.Superscript superscript)
      return DMXM.SuperscriptConverter.CreateOpenXmlElement(superscript);

    return null;
  }

    public static bool? UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DMM.ICommonMathContent? value)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXM.Paragraph paragraph && value is DMM.Paragraph paragraphModel)
        return DMXM.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
      if (openXmlElement is DXM.OfficeMath officeMath && value is DMM.OfficeMath officeMathModel)
        return DMXM.OfficeMathConverter.UpdateOpenXmlElement(officeMath, officeMathModel);
      if (openXmlElement is DXM.Accent accent && value is DMM.Accent accentModel)
        return DMXM.AccentConverter.UpdateOpenXmlElement(accent, accentModel);
      if (openXmlElement is DXM.Bar bar && value is DMM.Bar barModel)
        return DMXM.BarConverter.UpdateOpenXmlElement(bar, barModel);
      if (openXmlElement is DXM.Box box && value is DMM.Box boxModel)
        return DMXM.BoxConverter.UpdateOpenXmlElement(box, boxModel);
      if (openXmlElement is DXM.BorderBox borderBox && value is DMM.BorderBox borderBoxModel)
        return DMXM.BorderBoxConverter.UpdateOpenXmlElement(borderBox, borderBoxModel);
      if (openXmlElement is DXM.Delimiter delimiter && value is DMM.Delimiter delimiterModel)
        return DMXM.DelimiterConverter.UpdateOpenXmlElement(delimiter, delimiterModel);
      if (openXmlElement is DXM.EquationArray equationArray && value is DMM.EquationArray equationArrayModel)
        return DMXM.EquationArrayConverter.UpdateOpenXmlElement(equationArray, equationArrayModel);
      if (openXmlElement is DXM.Fraction fraction && value is DMM.Fraction fractionModel)
        return DMXM.FractionConverter.UpdateOpenXmlElement(fraction, fractionModel);
      if (openXmlElement is DXM.MathFunction mathFunction && value is DMM.Function mathFunctionModel)
        return DMXM.MathFunctionConverter.UpdateOpenXmlElement(mathFunction, mathFunctionModel);
      if (openXmlElement is DXM.GroupChar groupChar && value is DMM.GroupChar groupCharModel)
        return DMXM.GroupCharConverter.UpdateOpenXmlElement(groupChar, groupCharModel);
      if (openXmlElement is DXM.LimitLower limitLower && value is DMM.LimitLower limitLowerModel)
        return DMXM.LimitLowerConverter.UpdateOpenXmlElement(limitLower, limitLowerModel);
      if (openXmlElement is DXM.LimitUpper limitUpper && value is DMM.LimitUpper limitUpperModel)
        return DMXM.LimitUpperConverter.UpdateOpenXmlElement(limitUpper, limitUpperModel);
      if (openXmlElement is DXM.Matrix matrix && value is DMM.Matrix matrixModel)
        return DMXM.MatrixConverter.UpdateOpenXmlElement(matrix, matrixModel);
      if (openXmlElement is DXM.Nary nary && value is DMM.Nary naryModel)
        return DMXM.NaryConverter.UpdateOpenXmlElement(nary, naryModel);
      if (openXmlElement is DXM.Phantom phantom && value is DMM.Phantom phantomModel)
        return DMXM.PhantomConverter.UpdateOpenXmlElement(phantom, phantomModel);
      if (openXmlElement is DXM.Radical radical && value is DMM.Radical radicalModel)
        return DMXM.RadicalConverter.UpdateOpenXmlElement(radical, radicalModel);
      if (openXmlElement is DXM.PreSubSuper preSubSuper && value is DMM.PreSubSuper preSubSuperModel)
        return DMXM.PreSubSuperConverter.UpdateOpenXmlElement(preSubSuper, preSubSuperModel);
      if (openXmlElement is DXM.Subscript subscript && value is DMM.Subscript subscriptModel)
        return DMXM.SubscriptConverter.UpdateOpenXmlElement(subscript, subscriptModel);
      if (openXmlElement is DXM.SubSuperscript subSuperscript && value is DMM.SubSuperscript subSuperscriptModel)
        return DMXM.SubSuperscriptConverter.UpdateOpenXmlElement(subSuperscript, subSuperscriptModel);
      if (openXmlElement is DXM.Superscript superscript && value is DMM.Superscript superscriptModel)
        return DMXM.SuperscriptConverter.UpdateOpenXmlElement(superscript, superscriptModel);
    }
    return false;
  }

}
