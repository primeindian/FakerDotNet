# Faker.Hipster

Adapted from [Hipster Ipsum](https://hipsum.co/)

```cs
Faker.Hipster.Word() //=> "irony"

# Optional arguments: count=3, supplemental=false, spacesAllowed = false
Faker.Hipster.Words() //=> ["pug", "pitchfork", "chia"]
Faker.Hipster.Words(4) //=> ["ugh", "cardigan", "poutine", "stumptown"]
Faker.Hipster.Words(4, true) //=> ["iste", "seitan", "normcore", "provident"]
Faker.Hipster.Words(4, true, true) //=> ["qui", "magni", "craft beer", "est"]

# Optional arguments: wordCount=4, supplemental=false, randomWordsToAdd=6
Faker.Hipster.Sentence() //=> "Park iphone leggings put a bird on it."
Faker.Hipster.Sentence(3) //=> "Pour-over swag godard."
Faker.Hipster.Sentence(3, true) //=> "Beard laboriosam sequi celiac."
Faker.Hipster.Sentence(3, false, 4) //=> "Bitters retro mustache aesthetic biodiesel 8-bit."
Faker.Hipster.Sentence(3, true, 4) //=> "Occaecati deleniti messenger bag meh crucifix autem."

# Optional arguments: sentenceCount=3, supplemental=false
Faker.Hipster.Sentences() //=> ["Godard pitchfork vinegar chillwave everyday 90's whatever.", "Pour-over artisan distillery street waistcoat.", "Salvia yr leggings franzen blue bottle."]
Faker.Hipster.Sentences(1)() //=> ["Before they sold out pinterest venmo umami try-hard ugh hoodie artisan."]
Faker.Hipster.Sentences(1, true) //=> ["Et sustainable optio aesthetic et."]

# Optional arguments: sentenceCount=3, supplemental=false, randomSentencesToAdd=3
Faker.Hipster.Paragraph() //=> "Migas fingerstache pbr&b tofu. Polaroid distillery typewriter echo tofu actually. Slow-carb fanny pack pickled direct trade scenester mlkshk plaid. Banjo venmo chambray cold-pressed typewriter. Fap skateboard intelligentsia."
Faker.Hipster.Paragraph(2) //=> "Yolo tilde farm-to-table hashtag. Lomo kitsch disrupt forage +1."
Faker.Hipster.Paragraph(2, true) //=> "Typewriter iste ut viral kombucha voluptatem. Sint voluptates saepe. Direct trade irony chia excepturi yuccie. Biodiesel esse listicle et quam suscipit."
Faker.Hipster.Paragraph(2, false, 4) //=> "Selvage vhs chartreuse narwhal vinegar. Authentic vinyl truffaut carry vhs pop-up. Hammock everyday iphone locavore thundercats bitters vegan goth. Fashion axe banh mi shoreditch whatever artisan."
Faker.Hipster.Paragraph(2, true, 4) //=> "Deep v gluten-free unde waistcoat aperiam migas voluptas dolorum. Aut drinking illo sustainable sapiente. Direct trade fanny pack kale chips ennui semiotics."

# Optional arguments: paragraphCount=3, supplemental=false
Faker.Hipster.Paragraphs() //=> ["Tilde microdosing blog cliche meggings. Intelligentsia five dollar toast forage yuccie. Master kitsch knausgaard. Try-hard everyday trust fund mumblecore.", "Normcore viral pickled. Listicle humblebrag swag tote bag. Taxidermy street hammock neutra butcher cred kale chips. Blog portland humblebrag trust fund irony.", "Single-origin coffee fixie cleanse tofu xoxo. Post-ironic tote bag ramps gluten-free locavore mumblecore hammock. Umami loko twee. Ugh kitsch before they sold out."]
Faker.Hipster.Paragraphs(1) //=> ["Skateboard cronut synth +1 fashion axe. Pop-up polaroid skateboard asymmetrical. Ennui fingerstache shoreditch before they sold out. Tattooed pitchfork ramps. Photo booth yr messenger bag raw denim bespoke locavore lomo synth."]
Faker.Hipster.Paragraphs(1, true) //=> ["Quae direct trade pbr&b quo taxidermy autem loko. Umami quas ratione migas cardigan sriracha minima. Tenetur perspiciatis pickled sed eum doloribus truffaut. Excepturi dreamcatcher meditation."]

# Optional arguments: chars=3, supplemental=false
Faker.Hipster.ParagraphByChars() //=> "Truffaut stumptown trust fund 8-bit messenger bag portland. Meh kombucha selvage swag biodiesel. Lomo kinfolk jean shorts asymmetrical diy. Wayfarers portland twee stumptown. Wes anderson biodiesel retro 90's pabst. Diy echo 90's mixtape semiotics. Cornho."
Faker.Hipster.ParagraphByChars(256, false) //=> "Hella kogi blog narwhal sartorial selfies mustache schlitz. Bespoke normcore kitsch cred hella fixie. Park aesthetic fixie migas twee. Cliche mustache brunch tumblr fixie godard. Drinking pop-up synth hoodie dreamcatcher typewriter. Kitsch biodiesel green."
```
