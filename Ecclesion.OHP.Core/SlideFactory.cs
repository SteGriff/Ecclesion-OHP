using Ecclesion.OHP.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP.Core
{
    public class SlideFactory
    {
        public static Font Font { get; set; }

        public List<Slide> Slides;

        public SlideFactory(string content, int emSizeInPoints, int slideWidth, int slideHeight)
        {
            Slide currentSlide = new Slide();
            Slides = new List<Slide>();

            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    Slides.Add(currentSlide);
                    currentSlide = new Slide();
                }
                else
                {
                    currentSlide.Text += line + Environment.NewLine;
                }
            }

            //Add the final slide
            Slides.Add(currentSlide);

            var vLabel = new Label()
            {
                Font = Font,
                MinimumSize = new System.Drawing.Size(slideWidth, slideHeight),
                AutoSize = true
            };

            int index = 0;
            var finalSlides = new List<Slide>();

            foreach (var slide in Slides)
            {
                vLabel.Text = slide.Text;
                string extraText = "";

                //Slide content too tall for label; split into two slides
                if (vLabel.PreferredHeight > vLabel.MinimumSize.Height)
                {
                    while (vLabel.PreferredHeight > vLabel.MinimumSize.Height)
                    {
                        //Reduce vLabel text by removing the last line until it fits
                        vLabel.Text = vLabel.Text.Substring(0, vLabel.Text.LastIndexOf(Environment.NewLine));

                        //Get the slide text which is after vLabel text
                        extraText = slide.Text.Substring(vLabel.Text.Length);
                    }

                    //TOTO SG DRY (see else block) 1
                    index += 1;
                    slide.Text = vLabel.Text;
                    slide.Index = index;
                    finalSlides.Add(slide);

                    if (extraText != "")
                    {
                        index += 1;

                        //Make a new slide for the extra text
                        Slide newSlide = new Slide()
                        {
                            Text = extraText,
                            Index = index
                        };


                        finalSlides.Add(newSlide);
                    }
                }
                else
                {
                    //TODO SG DRY 2
                    index += 1;
                    slide.Text = vLabel.Text;
                    slide.Index = index;
                    finalSlides.Add(slide);
                }
            }
            
            Slides = finalSlides;
        }
        

    }
}
