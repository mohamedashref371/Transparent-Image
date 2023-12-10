# Transparent image by two images v1.0
Convert a normal image to transparent by two different images

Because some features have been deleted in the new version, you can download version zero from [here](http://www.mediafire.com/file/zy4teu5v14uf7ls). 

And here are some pictures: [click](https://facebook.com/FamilyKingsandQueensofcomputer371/posts/pfbid034AJYszDYamLVupw3Mem5K9FYkPD3nbiAMLEdaiZygWwkB8RhN2qc7V3AAX2bU5e4l)
****************************

Explanation of mathematical equations:

let background = rgb(R, G, B), originalColor = rgba(r, g, b, a);

When the color is displayed on the background, the result is rgb(rsltR, rsltG, rsltB)<br>
rsltR = (1 - a) * R + a * r<br>
rsltG = (1 - a) * G + a * g<br>
rsltB = (1 - a) * B + a * b

And now...
let background1 = rgb(R1, G1, B1), result1 = rgb(rsltR1, rsltG1, rsltB1);
let background2 = rgb(R2, G2, B2), result2 = rgb(rsltR2, rsltG2, rsltB2);

And we want to infer the originalColor.

rsltR1 = (1 - a) * R1 + a * r  ==> 1<br>
rsltR2 = (1 - a) * R2 + a * r  ==> 2

By subtracting equation 2 from equation 1<br>
rsltR1 - rsltR2 = (1 - a) * R1 - (1 - a) * R2 = (1 - a)(R1 - R2)

So a = 1 - (rsltR1 - rsltR2)/(R1 - R2)

And From equation 1<br>
r = (rsltR1 - (1 - a) * R1)/a
