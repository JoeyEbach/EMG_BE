using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMG.Migrations
{
    public partial class DataCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C Major" },
                    { 2, "G Major" },
                    { 3, "D Major" },
                    { 4, "A Major" },
                    { 5, "E Major" },
                    { 6, "B Major" },
                    { 7, "F# Major" },
                    { 8, "Db Major" },
                    { 9, "Ab Major" },
                    { 10, "Eb Major" },
                    { 11, "Bb Major" },
                    { 12, "F Major" },
                    { 13, "A Minor" },
                    { 14, "E Minor" },
                    { 15, "B Minor" },
                    { 16, "F# Minor" },
                    { 17, "C# Minor" },
                    { 18, "G# Minor" },
                    { 19, "D# Minor" },
                    { 20, "A# Minor" },
                    { 21, "D Minor" },
                    { 22, "G Minor" },
                    { 23, "C Minor" },
                    { 24, "F Minor" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Credit Card" },
                    { 2, "PayPal" },
                    { 3, "Bank Transfer" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Recording service for tracks", "Recording" },
                    { 2, "Mixing service for tracks", "Mixing" },
                    { 3, "Mastering service for tracks", "Mastering" },
                    { 4, "Editing service for tracks", "Editing" },
                    { 5, "Producing service for tracks", "Producing" },
                    { 6, "Songwriting service for tracks", "Songwriting" },
                    { 7, "Arrangement service for tracks", "Arrangement" },
                    { 8, "Consultation for music projects", "Consultation" },
                    { 9, "Live recording service", "Live Recording" },
                    { 10, "Rehearsal space service", "Rehearsal" },
                    { 11, "Vocal tuning service", "Vocal Tuning" },
                    { 12, "Session musician service", "Session Musician" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Image", "IsProducer", "Name", "Phone", "Uid" },
                values: new object[,]
                {
                    { 1, "john.smith@example.com", "john_smith.png", true, "John Smith", "123-456-7890", "UID001" },
                    { 2, "mary.jane@example.com", "mary_jane.png", false, "Mary Jane", "234-567-8901", "UID002" },
                    { 3, "bob.doe@example.com", "bob_doe.png", true, "Bob Doe", "345-678-9012", "UID003" },
                    { 4, "alice.chan@example.com", "alice_chan.png", false, "Alice Chan", "456-789-0123", "UID004" },
                    { 5, "ryan.lee@example.com", "ryan_lee.png", true, "Ryan Lee", "567-890-1234", "UID005" },
                    { 6, "kiran.patel@example.com", "kiran_patel.png", false, "Kiran Patel", "678-901-2345", "UID006" }
                });

            migrationBuilder.InsertData(
                table: "ProducerServices",
                columns: new[] { "Id", "Active", "Price", "ProducerId", "ServiceId" },
                values: new object[,]
                {
                    { 1, true, 100m, 1, 1 },
                    { 2, true, 150m, 1, 2 },
                    { 3, true, 200m, 3, 1 },
                    { 4, false, 180m, 3, 3 },
                    { 5, true, 130m, 5, 2 },
                    { 6, true, 160m, 5, 3 },
                    { 7, true, 120m, 1, 4 },
                    { 8, true, 220m, 3, 4 },
                    { 9, false, 140m, 5, 1 },
                    { 10, true, 170m, 1, 5 },
                    { 11, false, 190m, 3, 5 },
                    { 12, true, 210m, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Bpm", "CompleteDate", "CustomerId", "IsComplete", "KeyId", "Lyric", "Notes", "PaymentTypeId", "ProducerId", "StartDate", "Title", "Worktape" },
                values: new object[,]
                {
                    { 1, 120, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, "Now that it's all said and done\nI can't believe you were the one\nTo build me up and tear me down\nLike an old abandoned house\nWhat you said when you left\nJust left me cold and out of breath\nI fell too far, was in way too deep\nGuess I let you get the best of me\nWell, I never saw it coming\nI should've started running a long, long time ago\nAnd I never thought I'd doubt you\nI'm better off without you\nMore than you, more than you know\nI'm slowly getting closure\nI guess it's really over\nI'm finally getting better\nNow, I'm picking up the pieces\nAnd spending all of these years\nPutting my heart back together", "Please make sure the vocalist sticks to the worktape melody.", 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Over You", "worktape_alpha.mp3" },
                    { 2, 128, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, 2, "I'm gonna make a change\nFor once in my life\nIt's gonna feel real good\nGonna make a difference\nGonna make it right\nAs I, turn up the collar on\nMy favorite winter coat\nThis wind is blowin' my mind\nI see the kids in the street\nWith not enough to eat\nWho am I, to be blind pretending not to see their needs?\nA summer's disregard\nA broken bottle top\nAnd a one man's soul\nThey follow each other on the wind ya know\n'Cause they got nowhere to go\nThat's why I want you to know\nI'm starting with the man in the mirror\nI'm asking him to change his ways\nAnd no message could've been any clearer\nIf they wanna make the world a better place\nTake a look at yourself and then make a change", "I'm shooting for an epic feel here, less pop and more a sync-vibe. If the tempo feels too fast feel free to slow it down a couple clicks", 2, 3, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Man In The Mirror", "worktape_beta.mp3" },
                    { 3, 110, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true, 3, "Load up on guns, bring your friends\nIt's fun to lose and to pretend\nShe's over bored and self-assured\nOh, no, I know a dirty word\nHello, hello, hello, how low?\nHello, hello, hello, how low?\nHello, hello, hello, how low?\nHello, hello, hello\nWith the lights out, it's less dangerous\nHere we are now, entertain us\nI feel stupid and contagious\nHere we are now, entertain us\nA mulatto, an albino\nA mosquito, my libido, yeah\nHey\nYeah", "This is a straight up rocker. I want the song to build throughout. If you need references I can send them.", 3, 5, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smells Like Teen Spirit", "worktape_gamma.mp3" },
                    { 4, 135, null, 2, false, 4, "Spent 24 hours, I need more hours with you\nYou spent the weekend getting even, ooh\nWe spent the late nights making things right between us\nBut now it's all good, babe\nRoll that back wood, babe\nAnd play me close\n'Cause girls like you run 'round with guys like me\n'Til sun down when I come through\nI need a girl like you, yeah yeah\nGirls like you love fun and, yeah, me too\nWhat I want when I come through\nI need a girl like you, yeah yeah\nYeah yeah yeah, yeah yeah yeah\nI need a girl like you, yeah yeah\nYeah yeah yeah, yeah yeah yeah\nI need a girl like you", "I'm hoping for a similar vibe to Morgan Wallen's 'Whiskey Glasses'.", 1, 1, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "She's A City Girl Now", "worktape_delta.mp3" },
                    { 5, 140, null, 4, false, 5, "I'm at a payphone, trying to call home\nAll of my change I spent on you\nWhere have the times gone? Baby, it's all wrong\nWhere are the plans we made for two?\nYeah, I, I know it's hard to remember\nThe people we used to be\nIt's even harder to picture\nThat you're not here next to me\nYou say it's too late to make it\nBut is it too late to try?\nAnd in our time that you wasted\nAll of our bridges burned down\nI've wasted my nights\nYou turned out the lights\nNow, I'm paralyzed\nStill stuck in that time\nWhen we called it love\nBut even the sun sets in paradise", "I already hired the vocalist for this. She will be sending you the vocal stems as soon as she is done.", 2, 3, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Payphone", "worktape_epsilon.mp3" },
                    { 6, 118, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true, 6, "It must be your skin, I'm sinkin' in\nIt must be for real, 'cause now I can feel\nAnd I didn't mind, it's not my kind\nIt's not my time, to wonder why\nEverything gone white, everything's grey\nNow you're here, now you're away\nI don't want this, remember that\nI'll never forget, where you're at\nDon't let the days go by\nGlycerine, glycerine\nI'm never alone, I'm alone all the time\nAre you at one, or do you lie\nWe live in a wheel, where everyone steals\nBut when we rise, it's like strawberry fields\nIf I treated you bad, you'd bruise my face\nCouldn't love you more, you've got a beautiful taste", "I'm hoping for an atmospheric vibe over the electric guitars.", 3, 5, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glycerine", "worktape_zeta.mp3" },
                    { 7, 125, null, 2, false, 7, "You've got your ball\nYou've got your chain\nTied to me tight tie me up again\nWho's got their claws\nIn you my friend\nInto your heart I'll beat again\nSweet like candy to my soul\nSweet you rock\nAnd sweet you roll\nLost for you I'm so lost for you\nYou come crash into me\nAnd I come into you\nI come into you\nIn a boys dream\nIn a boys dream\nTouch your lips just so I know\nIn your eyes, love, it glows so\nI'm bare-boned and crazy for you\nWhen you come crash\nInto me, baby\nAnd I come into you\nIn a boys dream\nIn a boys dream\nIf I've gone overboard\nThen I'm begging you\nTo forgive me\nIn my haste\nWhen I'm holding you so girl\nClose to me", "All acoustic on this one, no electric guitars please.", 1, 1, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crash", "worktape_eta.mp3" },
                    { 8, 132, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, 8, "End of passion play, crumbling away\nI'm your source of self-destruction\nVeins that pump with fear, sucking darkest clear\nLeading on your death's construction\nTaste me, you will see\nMore is all you need\nDedicated to\nHow I'm killing you\nCome crawling faster\nObey your master\nYour life burns faster\nObey your master, master\nMaster of puppets, I'm pulling your strings\nTwisting your mind and smashing your dreams\nBlinded by me, you can't see a thing\nJust call my name, 'cause I'll hear you scream\nMaster, master\nJust call my name, 'cause I'll hear you scream\nMaster, master", "I'm thinking a Metallica vibe on this one!", 2, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master Of Puppets", "worktape_theta.mp3" },
                    { 9, 115, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true, 9, "All the right friends in all the right places\nSo yeah, we're goin' down\nThey got all the right moves in all the right faces\nSo yeah, we're goin' down\nLet's paint the picture of the perfect place\nThey got it better than what anyone's told you\nThey'll be the King of Hearts, and you're the Queen of Spades\nThen we'll fight for you like we were your soldiers\nI know we got it good, but they got it made\nAnd their grass is getting greener each day\nI know things are looking up, but soon they'll take us down\nBefore anybody's knowin' our name\nThey got all the right friends in all the right places\nSo yeah, we're goin' down\nThey got all the right moves in all the right faces\nSo yeah, we're goin' down", "This is for a pop pitch, so no country elements.", 3, 5, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "All The Right Moves", "worktape_iota.mp3" },
                    { 10, 122, null, 2, false, 10, "'Cause you're a sky, 'cause you're a sky full of stars\nI'm gonna give you my heart\n'Cause you're a sky, 'cause you're a sky full of stars\n'Cause you light up the path\nI don't care, go on and tear me apart\nI don't care if you do, ooh-ooh, ooh\n'Cause in a sky, 'cause in a sky full of stars\nI think I saw you\n'Cause you're a sky, 'cause you're a sky full of stars\nI wanna die in your arms, oh, oh-oh\n'Cause you get lighter the more it gets dark\nI'm gonna give you my heart, oh", "This is a special one to me, hoping to have it played for my fiance.", 1, 1, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sky Full Of Stars", "worktape_kappa.mp3" },
                    { 11, 138, null, 4, false, 11, "A full moon shinin' bright\nEdge of the water, we were feelin' alright\nBack down a country road\nThe girls are always hot, and the beer is ice cold\nCadillac, horns on the hood\nMy buddy Frankie had his dad hook him up good\nGirls smile when we roll by\nThey hop in the back, and we cruise to the river side\nNever gonna grow up (Whoa-oh)\nNever gonna slow down (Whoa-oh)\nWe were shinin' like lighters in the dark\nIn the middle of a rock show (Whoa-oh)\nWe were doin' it right (Whoa-oh)\nWe were comin' alive (Whoa-oh)\nYeah, caught in a southern summer, barefoot, blue jean night", "I think some steel and a banjo would be great on this.", 2, 3, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barefoot Blue Jean Night", "worktape_lambda.mp3" },
                    { 12, 130, null, 6, false, 12, "When I picked you up for our first date baby\nWell, your pretty blue eyes, they were drivin' me crazy\nAnd the tiny little thought that was so amazing\nIs they were looking at me.\nI held open the car door for you then you climbed\nInside and slid on over\nTo the other side, I thought my, oh my\nSweet thing\nThe moon is high and the night is young\nCome on and meet me\nIn the backyard under the Cottonwood tree\nIt's a good thing and I'm wishing\nC'mon sweet thing\nWon't you climb on out of your window\nWhile the world is sleeping\nYou know I need you\nAnd there's no way I'll be leaving\n'Till we're kissing on the porch swing\nOh my little sweet thing", "This is just the first draft of the lyrics. Once the instrumental is done, I'll send a final lyric.", 3, 5, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweet Thing", "worktape_mu.mp3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProducerServices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
