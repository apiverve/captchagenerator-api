using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.CaptchaGenerator
{
    /// <summary>
    /// Query options for the Captcha Generator API
    /// </summary>
    public class CaptchaGeneratorQueryOptions
    {
        /// <summary>
        /// text draws random characters; math draws an arithmetic question such as 7 + 4 = ? and the solution is the answer. length, charset and unambiguous apply to text only
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Number of characters in the captcha (4-8) (text only)
        /// </summary>
        [JsonProperty("length")]
        public int? Length { get; set; }

        /// <summary>
        /// Characters to draw from: lowercase letters, uppercase letters, mixed-case letters, digits, or letters and digits (text only)
        /// </summary>
        [JsonProperty("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// Leave out characters that are easy to misread: 0, O, o, 1, l, I, i and Q (text only)
        /// </summary>
        [JsonProperty("unambiguous")]
        public bool? Unambiguous { get; set; }

        /// <summary>
        /// Distortion level. Harder levels add more rotation, warp, noise lines, background texture and a line through the text. For type=math it also sets the numbers: small additions and subtractions at easy, larger ones at medium, multiplication at hard. It does not change the audio; see audioNoise
        /// </summary>
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        /// <summary>
        /// Image width in pixels (100-400)
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Image height in pixels (40-150)
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Image format
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Text color as a hex code (e.g. #1d3557). By default each character gets a random dark color
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// Background color as a hex code (e.g. #ffffff)
        /// </summary>
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Also return a spoken WAV version of the same challenge in audioURL, for visitors who cannot see the image. Text captchas are read character by character; math questions are read aloud without the answer
        /// </summary>
        [JsonProperty("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Background noise in the audio, with audio=true: none (clearest, best for accessibility), low, medium or high. Higher levels make automated transcription harder and the audio harder to follow
        /// </summary>
        [JsonProperty("audioNoise")]
        public string AudioNoise { get; set; }

        /// <summary>
        /// Return the image as a base64 data URI in dataURI (and the audio in audioDataURI) instead of storing them; downloadURL and audioURL are then null
        /// </summary>
        [JsonProperty("inline")]
        public bool? Inline { get; set; }
    }
}
