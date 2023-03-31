namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Default Run Properties.
/// </summary>
public class RunPropertiesDefault: ModelElement
{
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [XmlContentElement] public RunPropertiesBaseStyle? RunPropertiesBaseStyle { get; set; }
}