namespace DocumentModel.Interop.Word;

public partial interface OCXEvents
{
  /// <summary>
  /// Occurs when the OCX control receives focus.
  /// </summary>
  public void GotFocus();

  /// <summary>
  /// Occurs when the OCX control loses focus.
  /// </summary>
  public void LostFocus();
}
