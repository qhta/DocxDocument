
using System.ComponentModel;

namespace ModelGen;

public class MemberElement : ModelElement
{
  /// <summary>
  /// Default constructor. Needed for serialization.
  /// </summary>
  public MemberElement() { }

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="name"></param>
  public MemberElement(string name): base(name)
  {
  }

  [XmlIgnore]
  public TypeInfo? DeclaringType => (TypeInfo?)Owner;
  [XmlIgnore]
  public System.Reflection.MemberInfo? ReflectionInfo { get; set; }

  /// <summary>
  /// Members are usually added in ScanSource phase, however can be added in later phase.
  /// </summary>
  [DefaultValue(PPS.ScanSource)]
  public PPS AddedInPhase { get; set; } = PPS.ScanSource;

}