Range(1,10).foreach(x=>println(Range(1,x+1).map(y=>f"$y*$x=${x*y}").mkString("\t")))
