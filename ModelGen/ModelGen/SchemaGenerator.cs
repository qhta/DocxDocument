using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation.Schema;
using System.Xml;
using DocumentFormat.OpenXml.Framework;

namespace ModelGen;

public class SchemaGenerator
{
  private XmlSchemaSet SchemaSet = new XmlSchemaSet();
  XmlNamespaceManager NamespaceManager = new XmlNamespaceManager(new NameTable());
  public void RunOn(Assembly assembly)
  {
    var outputPath = Path.GetDirectoryName(assembly.Location);
    if (outputPath != null)
    {
      while (!outputPath.EndsWith(@"\bin"))
        outputPath = Path.GetDirectoryName(outputPath) ?? "";
      outputPath = Path.GetDirectoryName(outputPath) ?? "";
      outputPath = Path.Combine(outputPath, "Schemas");
      if (!Directory.Exists(outputPath))
        Directory.CreateDirectory(outputPath);
      foreach (var file in Directory.EnumerateFiles(outputPath, "*.xsd").ToArray())
      {
        File.Delete(file);
      }
    }

    SchemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallbackOne);
    NamespaceManager.AddNamespace("xs", "http://www.w3.org/2001/XMLSchema");
    foreach (var item in ModelData.Namespaces)
      NamespaceManager.AddNamespace(item.Item1, item.Item2);

    TimeSpan totalTime = TimeSpan.Zero;
    totalTime += ScanTypes(assembly);

    Console.WriteLine($"Total time = {totalTime}");

    totalTime += WriteSchemaSet(outputPath);
  }

  private TimeSpan ScanTypes(Assembly assembly)
  {
    Console.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    var foundTypesCount = 0;
    var approvedTypesCount = 0;
    foreach (var type in assembly.GetTypes())
    {
      if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? ""))
      {
        foundTypesCount++;
        if (TryAcceptType(type, SchemaSet))
        {
          approvedTypesCount++;
        }
      }
    }
    Console.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    Console.WriteLine($"Scanning time {ts}");
    Console.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
    return ts;
  }

  private bool TryAcceptType(Type type, XmlSchemaSet schemaSet)
  {
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+') || typeName.Contains('&') || typeName.Contains('`'))
      return false;
    var nspace = type.Namespace;
    XmlSchema schema = null!;
    if (!schemaSet.Contains(nspace))
    {
      schema = new XmlSchema { TargetNamespace = nspace };
      schemaSet.Add(schema);
    }
    else
    {
      foreach (var item in schemaSet.Schemas(nspace))
      {
        schema = (XmlSchema)item;
        break;
      }
    }
    if (schema == null)
      return false;
    if (type.IsEnum)
    {
      schema.Items.Add(GenerateEnumSchemaElement(type));
      return true;
    }
    else
    {
      if (!type.IsAbstract && !type.ContainsGenericParameters)
      {
        var element = type.GetConstructor(new Type[0])?.Invoke(new object[0]) as OpenXmlElement;
        if (element != null)
        {
          var elementMetadata = new ElementMetadataFactoryFeature().GetMetadata(element);
          var schemaElement = GenerateSchemaElementFromMetadata(type, elementMetadata);
          schema.Items.Add(schemaElement);
          return true;

          //    var elementMetadata = new ElementMetadataFactoryFeature().GetMetadata(element);
          //    //schemaElement.RefName = new XmlQualifiedName(elementMetadata.QName.Name, elementMetadata.QName.Namespace.Uri);
          //    //    var particle = elementMetadata.Particle?.Particle;
          //    //    if (particle != null) InspectParticle(type, particle);
          //    //    return true;
        }
      }
    }
    return false;
  }

  private XmlSchemaType GenerateEnumSchemaElement(Type type)
  {
    var xmlSchemaType = new XmlSchemaSimpleType();
    xmlSchemaType.Name = type.Name;
    var restriction = new XmlSchemaSimpleTypeRestriction();
    restriction.BaseTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
    foreach (var enumValue in type.GetEnumNames())
    {
      var facet = new XmlSchemaEnumerationFacet();
      facet.Value = enumValue;
      restriction.Facets.Add(facet);
    }
    xmlSchemaType.Content = restriction;
    return xmlSchemaType;
  }

  private XmlSchemaType GenerateSchemaElementFromMetadata(Type type, IElementMetadata metadata)
  {
    if (metadata.Children.Count == 0)
    {
      var xmlSchemaType = new XmlSchemaSimpleType();
      xmlSchemaType.Name = metadata.Type.Name;
      var baseType = type.BaseType;
      if (baseType != null)
      {
        var restriction = new XmlSchemaSimpleTypeRestriction();
        restriction.BaseTypeName = new XmlQualifiedName(baseType.Name, baseType.Namespace);
        xmlSchemaType.Content = restriction;
      }
      return xmlSchemaType;
    }
    else
    {
      var xmlSchemaType = new XmlSchemaComplexType();
      xmlSchemaType.Name = metadata.Type.Name;
      var baseType = type.BaseType;
      if (baseType != null)
      {
        var complexContent = new XmlSchemaComplexContent();
        xmlSchemaType.ContentModel = complexContent;
        var restriction = new XmlSchemaComplexContentRestriction();
        complexContent.Content = restriction;
        restriction.BaseTypeName = new XmlQualifiedName(baseType.Name, baseType.Namespace);
        xmlSchemaType.Particle = GenerateParticle(metadata.Particle);
      }
      return xmlSchemaType;
    }
  }

  private XmlSchemaParticle? GenerateParticle(CompiledParticle? openXmlParticle)
  {
    if (openXmlParticle?.Particle != null)
      return GenerateParticle(openXmlParticle.Particle);
    return null;
  }

  private XmlSchemaParticle? GenerateParticle(ParticleConstraint? particle)
  {
    if (particle == null)
      return null;
    switch (particle.ParticleType)
    {
      case ParticleType.Element:
        return GenerateElementParticle(particle);
      case ParticleType.All:
        return new XmlSchemaAll();
      case ParticleType.Any:
        return new XmlSchemaAny();
      case ParticleType.Choice:
        return GenerateChoiceParticle(particle);
      //case ParticleType.Group:

      case ParticleType.Sequence:
        return GenerateSequenceParticle(particle);
        //case ParticleType.AnyWithUri:
    }
    return null;
  }

  private XmlSchemaParticle? GenerateElementParticle(ParticleConstraint? particle)
  {
    if (particle is ElementParticle elementParticle)
    {
      var elementType = elementParticle.ElementType;
      var schemaElement = new XmlSchemaElement();
      schemaElement.SchemaTypeName = new XmlQualifiedName(elementType.Name, elementType.Namespace);
      if (particle.MinOccurs != 1 && particle.MaxOccurs != 1)
      {
        schemaElement.MinOccurs = particle.MinOccurs;
        schemaElement.MaxOccurs = particle.MaxOccurs;
      }
      return schemaElement;
    }
    return null;
  }

  private XmlSchemaParticle? GenerateChoiceParticle(ParticleConstraint? particle)
  {
    if (particle != null)
    {
      var choiceElement = new XmlSchemaChoice();
      if (particle.MinOccurs != 1 && particle.MaxOccurs != 1)
      {
        choiceElement.MinOccurs = particle.MinOccurs;
        choiceElement.MaxOccurs = particle.MaxOccurs;
      }
      if (particle is CompositeParticle compositeParticle)
        foreach (var childParticle in compositeParticle.ChildrenParticles)
        {
          var item = GenerateParticle(childParticle);
          if (item != null)
            choiceElement.Items.Add(item);
        }
      return choiceElement;
    }
    return null;
  }

  private XmlSchemaParticle? GenerateSequenceParticle(ParticleConstraint? particle)
  {
    if (particle != null)
    {
      var sequenceElement = new XmlSchemaSequence();
      if (particle.MinOccurs != 1 && particle.MaxOccurs != 1)
      {
        sequenceElement.MinOccurs = particle.MinOccurs;
        sequenceElement.MaxOccurs = particle.MaxOccurs;
      }
      if (particle is CompositeParticle compositeParticle)
        foreach (var childParticle in compositeParticle.ChildrenParticles)
        {
          var item = GenerateParticle(childParticle);
          if (item != null)
            sequenceElement.Items.Add(item);
        }
      return sequenceElement;
    }
    return null;
  }
  private XmlSchemaParticle? GenerateAllParticle(ParticleConstraint? particle)
  {
    if (particle != null)
    {
      return new XmlSchemaAll();
    }
    return null;
  }

  private TimeSpan WriteSchemaSet(string? outputPath)
  {
    Console.WriteLine("Writing schemas");
    DateTime t1 = DateTime.Now;
    SchemaSet.Compile();
    int count = 0;
    foreach (XmlSchema schema in SchemaSet.Schemas())
    {
      if (outputPath == null)
        schema.Write(Console.Out, NamespaceManager);
      else
      {
        var filename = Path.Combine(outputPath, schema.TargetNamespace + ".xsd");
        Console.WriteLine(filename);
        using (var textWriter = File.CreateText(filename))
          schema.Write(textWriter, NamespaceManager);
      }
      count++;
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    Console.WriteLine($"Write time {ts}");
    Console.WriteLine($"Written {count} schemas");
    return ts;

  }

  public static void ValidationCallbackOne(object? sender, ValidationEventArgs args)
  {
    Console.WriteLine(args.Message);
  }
}