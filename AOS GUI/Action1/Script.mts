Browser("Advantage Shopping").Page("Advantage Shopping").Link("SpeakersCategoryTxt").Click @@ script infofile_;_ZIP::ssf1.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("PRICE").Click @@ script infofile_;_ZIP::ssf2.xml_;_
'Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("WebElement").Click
Browser("Advantage Shopping").Page("Advantage Shopping").Link("COMPATIBILITY").Click @@ script infofile_;_ZIP::ssf4.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebCheckBox("compatibility_0").Set "OFF" @@ script infofile_;_ZIP::ssf5.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebCheckBox("compatibility_0").Set "ON" @@ script infofile_;_ZIP::ssf6.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("MANUFACTURER").Click @@ script infofile_;_ZIP::ssf7.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebCheckBox("manufacturer_2").Set "ON"
Browser("Advantage Shopping_2").Page("Advantage Shopping").Check CheckPoint("Advantage Shopping") @@ script infofile_;_ZIP::ssf16.xml_;_
Browser("Advantage Shopping").WinObject("Chrome Legacy Window").Check CheckPoint("Chrome Legacy Window") @@ hightlight id_;_525302_;_script infofile_;_ZIP::ssf9.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("$49.99").Click @@ script infofile_;_ZIP::ssf10.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("save_to_cart").Click @@ script infofile_;_ZIP::ssf11.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Cart").Click
wait 5
Browser("Advantage Shopping_2").Page("Advantage Shopping").Check CheckPoint("Advantage Shopping_2") @@ script infofile_;_ZIP::ssf17.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Cart").Click @@ hightlight id_;_65696_;_script infofile_;_ZIP::ssf15.xml_;_
Browser("Advantage Shopping_2").Page("Advantage Shopping").WebElement("REMOVE").Click @@ script infofile_;_ZIP::ssf18.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME").Click
