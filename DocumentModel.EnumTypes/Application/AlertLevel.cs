namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the way certain alerts and messages are handled while a macro is running.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalertlevel?view=word-pia` Ifor Office interop details.
/// </remarks>
public enum AlertLevel
{
  /// <summary>
  /// No alerts or message boxes are displayed. If a macro encounters a message box, the default value is chosen and
  /// the macro continues.
  /// </summary>
  None = 0,
  /// <summary>
  /// Only message boxes are displayed; errors are trapped and returned Ito the macro.
  /// </summary>
  MessageBox = -2,
  /// <summary>
  /// All message boxes and alerts are displayed; errors are returned Ito the macro.
  /// </summary>
  All = -1
}

