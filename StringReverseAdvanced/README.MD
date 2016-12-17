# StringReverseAdvanced
Another technical interview task
Writing this project i was inspired by https://dou.ua/lenta/articles/startup-interview/
well, i have tested some variants of realization. Summing-up:
- XOR operator is pretty fast for short char arrays, but it takes a long time to reverse 50+ symbols using this method.
- Array.Reverse() is a bit slow on short distances comparing to XOR, but the fastest further.
- StringBuilder was the slowest on all tests, but maybe it depends on how i made a function:
 text = builder.ToString().ToCharArray();
            return text;
I am sure the way i did it is not the fastest one.
- Reversing it manually by replacing elements in char array is fast enough to beat SB & XOR at medium & long distances, but it is not enough to make it faster than Array.Reverse().

<img src = "https://pp.vk.me/c638624/v638624859/9aa9/V157mEWTpyE.jpg"/>
            
Contact me in github if you know the way of doing it faster, im interested.
