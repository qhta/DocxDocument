using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;
using DocumentModel.Wordprocessing;

namespace DocumentModel.InOpenXml.Test
{
	/// <summary>
	/// Comprehensive serialization test for DocumentModel.Fonts.
	/// </summary>
	public static class FontsTest
	{
		/// <summary>
		/// Runs all Fonts serialization tests.
		/// </summary>
		/// <returns>True if all tests pass; otherwise, false.</returns>
		public static bool Run()
		{
			Console.WriteLine("=== Fonts Test ===\n");
			if (!TestXmlSerialization()) return false;
			if (!TestJsonSerialization()) return false;
			if (!TestEdgeCases()) return false;
			if (!TestStoreInDocument()) return false;
			if (!TestUpdateInDocument()) return false;
			if (!TestValidateOpenXml()) return false;
      Console.WriteLine("All Fonts tests passed.\n");
			return true;
		}

		/// <summary>
		/// Tests XML serialization and deserialization of Fonts.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestXmlSerialization()
		{
			Console.WriteLine("--- XML Serialization ---");
			var testData = CreateSampleFonts();
			{
				var xmlSerializer = new XmlSerializer(typeof(Fonts));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, testData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Serialized XML:\n" + xmlString);

				Fonts? deserialized;
				using (var stringReader = new StringReader(xmlString))
				{
					deserialized = (Fonts?)xmlSerializer.Deserialize(stringReader);
				}
				if (deserialized == null)
				{
					Console.WriteLine("✗ XML Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
				{
					Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
					return false;
				}
				Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests JSON serialization and deserialization of Fonts.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestJsonSerialization()
		{
			Console.WriteLine("--- JSON Serialization ---");
			var testData = CreateSampleFonts();
			{
        var jsonOptions = JsonConfig.Options;
				string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
				Console.WriteLine("Serialized JSON:\n" + jsonString);

				var deserialized = JsonSerializer.Deserialize<Fonts>(jsonString, jsonOptions);
				if (deserialized == null)
				{
					Console.WriteLine("✗ JSON Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
				{
					Console.WriteLine($"✗ JSON Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
					return false;
				}
				Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests edge cases like empty Fonts object.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestEdgeCases()
		{
			Console.WriteLine("--- Edge Cases ---");
			{
				var empty = new Fonts();
				string xml = SerializeToXml(empty);
				var xmlDeserialized = DeserializeFromXml(xml);
				if (xmlDeserialized == null)
				{
					Console.WriteLine("✗ Edge case: XML deserialization of empty object failed");
					return false;
				}
				string json = SerializeToJson(empty);
				var jsonDeserialized = DeserializeFromJson(json);
				if (jsonDeserialized == null)
				{
					Console.WriteLine("✗ Edge case: JSON deserialization of empty object failed");
					return false;
				}
				Console.WriteLine("✓ Edge case tests passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests setting sample Fonts to a new document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document Fonts can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document Fonts are successfully stored and verified; otherwise, false.</returns>
		static bool TestStoreInDocument()
		{
			Console.WriteLine("--- Store sample Fonts in new document---");
			{
				Fonts testData = CreateSampleFonts();
				using (var document = Document.CreateDocument("temp.docx"))
				{
					document.Fonts = testData;
				}

				Fonts storedData;
				using (var document = Document.OpenDocument("temp.docx"))
				{
					storedData = document.Fonts ?? throw new InvalidOperationException("Fonts not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(Fonts));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Fonts stored to new document and reloaded from it:\n" + xmlString);

				if (!TestHelper.CompareTestData(testData, storedData, out var propName))
				{
					Console.WriteLine($"✗ Store sample Fonts test FAILED - data mismatch in '{propName}'");
					return false;
				}

				Console.WriteLine("✓ Store sample Fonts test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Tests updating the Fonts of a document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document Fonts can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document Fonts are successfully updated and verified; otherwise, false.</returns>
		static bool TestUpdateInDocument()
		{
			Console.WriteLine("--- Update document Fonts ---");
			{
				Fonts testData = CreateSampleFonts();
				var initialCount = testData.Count;
				using (var document = Document.CreateDocument("temp.docx"))
				{
					document.Fonts = testData;
    			document.Fonts.Add(new FontDef
          {
            FontName = "Windings",
            Aliases = "Courier",
            FontFamily = FontFamily.Auto,
            Charset = FontCharset.Symbol,
            Pitch = FontPitch.Fixed,
            Panose = "05000000000000000000",
            FontSignature = "00000000-10000000-00000000-00000000-80000000-00000000"
          });
				}
				Fonts storedData;
				using (var document = Document.OpenDocument("temp.docx"))
				{
					storedData = document.Fonts ?? throw new InvalidOperationException("Fonts not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(Fonts));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Updated document Fonts:\n" + xmlString);

				var storedCount = storedData.Count;
				if (storedCount != initialCount + 1)
				{
					Console.WriteLine($"✗ Updated document Fonts test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
					return false;
				}

				if (!TestHelper.CompareTestData(testData, storedData, out var propName))
				{
					Console.WriteLine($"✗ Updated document Fonts test FAILED - data mismatch in '{propName}'");
					return false;
				}

				Console.WriteLine("✓ Updated document Fonts test passed\n");
				return true;
			}
		}


    /// <summary>
    /// Tests setting sample Fonts to a new document and outputs the result to the console.
    /// </summary>
    /// <remarks>This method is intended for use in test scenarios to verify that document Fonts can
    /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
    /// inspection.</remarks>
    /// <returns>true if the document Fonts are successfully stored and verified; otherwise, false.</returns>
    static bool TestValidateOpenXml()
    {
      Console.WriteLine("--- Validate sample Fonts stored in new document against OpenXml schema ---");
      {
        Fonts testData = CreateSampleFonts();
        using (var document = Document.CreateDocument("temp.docx"))
        {
          document.Fonts = testData;
        }

        using (var document = Document.OpenDocument("temp.docx"))
        {
          var openXml = document.WordprocessingDocument!.MainDocumentPart!.FontTablePart!.Fonts!.OuterXml;
          openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
            "http://purl.oclc.org/ooxml/wordprocessingml/main");
				var formattedOpenXml = FormatXmlWithLineNumbers(openXml);
				Console.WriteLine(formattedOpenXml);
          var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
					if (!validationResult.IsValid)
					{
						Console.WriteLine("✗ OpenXml schema validation FAILED - issues found:");
						foreach (var message in validationResult.Messages)
						{
							Console.WriteLine($" {message}");
						}
						return false;
          }
        }

        Console.WriteLine("✓ Store sample Fonts test passed\n");
        return true;
      }
    }


    /// <summary>
    /// Creates a sample Fonts object with various property types.
    /// </summary>
    /// <returns>A populated Fonts object.</returns>
    static Fonts CreateSampleFonts()
		{
			var fonts = new Fonts();
			fonts.Add(new FontDef 
        { 
          FontName = "Arial", 
          Aliases = "Helvetica, Swiss", 
          FontFamily = FontFamily.Swiss,
					Pitch = FontPitch.Variable,
					Charset = FontCharset.EastEurope,
          Panose = "020B0604020202020204",
					FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
        });
        fonts.Add(new FontDef
        {
          FontName = "Times New Roman",
          Aliases = "Times",
          FontFamily = FontFamily.Roman,
          Pitch = FontPitch.Variable,
          Charset = FontCharset.Ansi,
          Panose = "02020603050405020304",
          FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
        });
        fonts.Add(new FontDef
        {
          FontName = "Courier New",
          Aliases = "Courier",
          FontFamily = FontFamily.Modern,
          Pitch = FontPitch.Fixed,
          Panose = "02070309020205020404",
          FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000",
					NotTrueType = true,
        });
      return fonts;
		}

		/// <summary>
		/// Serializes a Fonts object to an XML string.
		/// </summary>
		/// <param name="props">The Fonts object to serialize.</param>
		/// <returns>The serialized XML string.</returns>
		static string SerializeToXml(Fonts props)
		{
			var xmlSerializer = new XmlSerializer(typeof(Fonts));
			using (var stringWriter = new StringWriter())
			using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
			{
				xmlSerializer.Serialize(xmlWriter, props);
				return stringWriter.ToString();
			}
		}

		/// <summary>
		/// Deserializes a Fonts object from an XML string.
		/// </summary>
		/// <param name="xml">The XML string to deserialize.</param>
		/// <returns>The deserialized Fonts object, or null if deserialization fails.</returns>
		static Fonts? DeserializeFromXml(string xml)
		{
			var xmlSerializer = new XmlSerializer(typeof(Fonts));
			using (var stringReader = new StringReader(xml))
			{
				return (Fonts?)xmlSerializer.Deserialize(stringReader);
			}
		}

		/// <summary>
		/// Serializes a Fonts object to a JSON string.
		/// </summary>
		/// <param name="props">The Fonts object to serialize.</param>
		/// <returns>The serialized JSON string.</returns>
		static string SerializeToJson(Fonts props)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Serialize(props, jsonOptions);
		}

		/// <summary>
		/// Deserializes a Fonts object from a JSON string.
		/// </summary>
		/// <param name="json">The JSON string to deserialize.</param>
		/// <returns>The deserialized Fonts object, or null if deserialization fails.</returns>
		static Fonts? DeserializeFromJson(string json)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Deserialize<Fonts>(json, jsonOptions);
		}

    /// <summary>
    /// Formats XML string with line numbers for easier debugging.
    /// </summary>
    /// <param name="xml"></param>
    /// <returns></returns>
    static string FormatXmlWithLineNumbers(string xml)
		{
			var xmlDoc = new XmlDocument();
			using (var reader = XmlReader.Create(new StringReader(xml)))
			{
				xmlDoc.Load(reader);
			}

			var writerSettings = new XmlWriterSettings
			{
				Indent = true,
				NewLineHandling = NewLineHandling.Replace,
				NewLineChars = Environment.NewLine,
				OmitXmlDeclaration = false
			};

			using var stringWriter = new StringWriter();
			using (var xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
			{
				xmlDoc.Save(xmlWriter);
			}

			var formattedXml = stringWriter.ToString();
			var lines = formattedXml.Split(["\r\n", "\n", "\r"], StringSplitOptions.None);
			var builder = new StringBuilder(formattedXml.Length + lines.Length * 8);
			for (int i = 0; i < lines.Length; i++)
			{
				builder.Append((i + 1).ToString().PadLeft(4));
				builder.Append(": ");
				builder.AppendLine(lines[i]);
			}
			return builder.ToString();
		}
	}
}