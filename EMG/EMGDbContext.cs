using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using EMG.Models;

public class EMGDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Key> Keys { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }
    public DbSet<ProducerService> ProducerServices { get; set; }
    public DbSet<Service> Services { get; set; }


    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<User>().HasData(new User[]
    //        {
    //            new User
    //            {
    //                Id = 1,
    //                Name = "John Smith",
    //                Phone = "123-456-7890",
    //                Email = "john.smith@example.com",
    //                Image = "john_smith.png",
    //                IsProducer = true,
    //                Uid = "UID001",
    //            },
    //            new User
    //            {
    //                Id = 2,
    //                Name = "Mary Jane",
    //                Phone = "234-567-8901",
    //                Email = "mary.jane@example.com",
    //                Image = "mary_jane.png",
    //                IsProducer = false,
    //                Uid = "UID002",
    //            },
    //            new User
    //            {
    //                Id = 3,
    //                Name = "Bob Doe",
    //                Phone = "345-678-9012",
    //                Email = "bob.doe@example.com",
    //                Image = "bob_doe.png",
    //                IsProducer = true,
    //                Uid = "UID003",
    //            },
    //            new User
    //            {
    //                Id = 4,
    //                Name = "Alice Chan",
    //                Phone = "456-789-0123",
    //                Email = "alice.chan@example.com",
    //                Image = "alice_chan.png",
    //                IsProducer = false,
    //                Uid = "UID004",
    //            },
    //            new User
    //            {
    //                Id = 5,
    //                Name = "Ryan Lee",
    //                Phone = "567-890-1234",
    //                Email = "ryan.lee@example.com",
    //                Image = "ryan_lee.png",
    //                IsProducer = true,
    //                Uid = "UID005",
    //            },
    //            new User
    //            {
    //                Id = 6,
    //                Name = "Kiran Patel",
    //                Phone = "678-901-2345",
    //                Email = "kiran.patel@example.com",
    //                Image = "kiran_patel.png",
    //                IsProducer = false,
    //                Uid = "UID006",
    //            }
    //        });

        //modelBuilder.Entity<Project>().HasData(new Project[]
        //    {
        //        new Project
        //        {
        //            Id = 1,
        //            CustomerId = 2,
        //            ProducerId = 1,
        //            Title = "Over You",
        //            StartDate = new DateTime(2023, 1, 1),
        //            CompleteDate = "2023-06-30",
        //            IsComplete = true,
        //            KeyId = 1,
        //            Bpm = 120,
        //            Notes = "Please make sure the vocalist sticks to the worktape melody.",
        //            Lyric = "Now that it's all said and done\nI can't believe you were the one\nTo build me up and tear me down\nLike an old abandoned house\nWhat you said when you left\nJust left me cold and out of breath\nI fell too far, was in way too deep\nGuess I let you get the best of me\nWell, I never saw it coming\nI should've started running a long, long time ago\nAnd I never thought I'd doubt you\nI'm better off without you\nMore than you, more than you know\nI'm slowly getting closure\nI guess it's really over\nI'm finally getting better\nNow, I'm picking up the pieces\nAnd spending all of these years\nPutting my heart back together",
        //            Worktape = "worktape_alpha.mp3",
        //            PaymentTypeId = 1
        //        },
        //        new Project
        //        {
        //            Id = 2,
        //            CustomerId = 4,
        //            ProducerId = 3,
        //            Title = "Man In The Mirror",
        //            StartDate = new DateTime(2023, 2, 15),
        //            CompleteDate = "2023-08-15",
        //            IsComplete = true,
        //            KeyId = 2,
        //            Bpm = 128,
        //            Notes = "I'm shooting for an epic feel here, less pop and more a sync-vibe. If the tempo feels too fast feel free to slow it down a couple clicks",
        //            Lyric = "I'm gonna make a change\nFor once in my life\nIt's gonna feel real good\nGonna make a difference\nGonna make it right\nAs I, turn up the collar on\nMy favorite winter coat\nThis wind is blowin' my mind\nI see the kids in the street\nWith not enough to eat\nWho am I, to be blind pretending not to see their needs?\nA summer's disregard\nA broken bottle top\nAnd a one man's soul\nThey follow each other on the wind ya know\n'Cause they got nowhere to go\nThat's why I want you to know\nI'm starting with the man in the mirror\nI'm asking him to change his ways\nAnd no message could've been any clearer\nIf they wanna make the world a better place\nTake a look at yourself and then make a change",
        //            Worktape = "worktape_beta.mp3",
        //            PaymentTypeId = 2
        //        },
        //        new Project
        //        {
        //            Id = 3,
        //            CustomerId = 6,
        //            ProducerId = 5,
        //            Title = "Smells Like Teen Spirit",
        //            StartDate = new DateTime(2023, 3, 20),
        //            CompleteDate = "2023-09-20",
        //            IsComplete = false,
        //            KeyId = 3,
        //            Bpm = 110,
        //            Notes = "This is a straight up rocker. I want the song to build throughout. If you need references I can send them.",
        //            Lyric = "Load up on guns, bring your friends\nIt's fun to lose and to pretend\nShe's over bored and self-assured\nOh, no, I know a dirty word\nHello, hello, hello, how low?\nHello, hello, hello, how low?\nHello, hello, hello, how low?\nHello, hello, hello\nWith the lights out, it's less dangerous\nHere we are now, entertain us\nI feel stupid and contagious\nHere we are now, entertain us\nA mulatto, an albino\nA mosquito, my libido, yeah\nHey\nYeah",
        //            Worktape = "worktape_gamma.mp3",
        //            PaymentTypeId = 3
        //        },
        //        new Project
        //        {
        //            Id = 4,
        //            CustomerId = 2,
        //            ProducerId = 1,
        //            Title = "She's A City Girl Now",
        //            StartDate = new DateTime(2023, 4, 10),
        //            CompleteDate = "2023-10-10",
        //            IsComplete = false,
        //            KeyId = 4,
        //            Bpm = 135,
        //            Notes = "I'm hoping for a similar vibe to Morgan Wallen's 'Whiskey Glasses'.",
        //            Lyric = "Spent 24 hours, I need more hours with you\nYou spent the weekend getting even, ooh\nWe spent the late nights making things right between us\nBut now it's all good, babe\nRoll that back wood, babe\nAnd play me close\n'Cause girls like you run 'round with guys like me\n'Til sun down when I come through\nI need a girl like you, yeah yeah\nGirls like you love fun and, yeah, me too\nWhat I want when I come through\nI need a girl like you, yeah yeah\nYeah yeah yeah, yeah yeah yeah\nI need a girl like you, yeah yeah\nYeah yeah yeah, yeah yeah yeah\nI need a girl like you",
        //            Worktape = "worktape_delta.mp3",
        //            PaymentTypeId = 1
        //        },
        //        new Project
        //        {
        //            Id = 5,
        //            CustomerId = 4,
        //            ProducerId = 3,
        //            Title = "Payphone",
        //            StartDate = new DateTime(2023, 5, 5),
        //            CompleteDate = "2023-11-05",
        //            IsComplete = false,
        //            KeyId = 5,
        //            Bpm = 140,
        //            Notes = "I already hired the vocalist for this. She will be sending you the vocal stems as soon as she is done.",
        //            Lyric = "I'm at a payphone, trying to call home\nAll of my change I spent on you\nWhere have the times gone? Baby, it's all wrong\nWhere are the plans we made for two?\nYeah, I, I know it's hard to remember\nThe people we used to be\nIt's even harder to picture\nThat you're not here next to me\nYou say it's too late to make it\nBut is it too late to try?\nAnd in our time that you wasted\nAll of our bridges burned down\nI've wasted my nights\nYou turned out the lights\nNow, I'm paralyzed\nStill stuck in that time\nWhen we called it love\nBut even the sun sets in paradise",
        //            Worktape = "worktape_epsilon.mp3",
        //            PaymentTypeId = 2
        //        },
        //        new Project
        //        {
        //            Id = 6,
        //            CustomerId = 6,
        //            ProducerId = 5,
        //            Title = "Glycerine",
        //            StartDate = new DateTime(2023, 6, 1),
        //            CompleteDate = "2023-12-01",
        //            IsComplete = true,
        //            KeyId = 6,
        //            Bpm = 118,
        //            Notes = "I'm hoping for an atmospheric vibe over the electric guitars.",
        //            Lyric = "It must be your skin, I'm sinkin' in\nIt must be for real, 'cause now I can feel\nAnd I didn't mind, it's not my kind\nIt's not my time, to wonder why\nEverything gone white, everything's grey\nNow you're here, now you're away\nI don't want this, remember that\nI'll never forget, where you're at\nDon't let the days go by\nGlycerine, glycerine\nI'm never alone, I'm alone all the time\nAre you at one, or do you lie\nWe live in a wheel, where everyone steals\nBut when we rise, it's like strawberry fields\nIf I treated you bad, you'd bruise my face\nCouldn't love you more, you've got a beautiful taste",
        //            Worktape = "worktape_zeta.mp3",
        //            PaymentTypeId = 3
        //        },
        //        new Project
        //        {
        //            Id = 7,
        //            CustomerId = 2,
        //            ProducerId = 1,
        //            Title = "Crash",
        //            StartDate = new DateTime(2023, 7, 15),
        //            CompleteDate = "2024-01-15",
        //            IsComplete = false,
        //            KeyId = 7,
        //            Bpm = 125,
        //            Notes = "All acoustic on this one, no electric guitars please.",
        //            Lyric = "You've got your ball\nYou've got your chain\nTied to me tight tie me up again\nWho's got their claws\nIn you my friend\nInto your heart I'll beat again\nSweet like candy to my soul\nSweet you rock\nAnd sweet you roll\nLost for you I'm so lost for you\nYou come crash into me\nAnd I come into you\nI come into you\nIn a boys dream\nIn a boys dream\nTouch your lips just so I know\nIn your eyes, love, it glows so\nI'm bare-boned and crazy for you\nWhen you come crash\nInto me, baby\nAnd I come into you\nIn a boys dream\nIn a boys dream\nIf I've gone overboard\nThen I'm begging you\nTo forgive me\nIn my haste\nWhen I'm holding you so girl\nClose to me",
        //            Worktape = "worktape_eta.mp3",
        //            PaymentTypeId = 1
        //        },
        //        new Project
        //        {
        //            Id = 8,
        //            CustomerId = 4,
        //            ProducerId = 3,
        //            Title = "Master Of Puppets",
        //            StartDate = new DateTime(2023, 8, 20),
        //            CompleteDate = "2024-02-20",
        //            IsComplete = false,
        //            KeyId = 8,
        //            Bpm = 132,
        //            Notes = "I'm thinking a Metallica vibe on this one!",
        //            Lyric = "End of passion play, crumbling away\nI'm your source of self-destruction\nVeins that pump with fear, sucking darkest clear\nLeading on your death's construction\nTaste me, you will see\nMore is all you need\nDedicated to\nHow I'm killing you\nCome crawling faster\nObey your master\nYour life burns faster\nObey your master, master\nMaster of puppets, I'm pulling your strings\nTwisting your mind and smashing your dreams\nBlinded by me, you can't see a thing\nJust call my name, 'cause I'll hear you scream\nMaster, master\nJust call my name, 'cause I'll hear you scream\nMaster, master",
        //            Worktape = "worktape_theta.mp3",
        //            PaymentTypeId = 2
        //        },
        //        new Project
        //        {
        //            Id = 9,
        //            CustomerId = 6,
        //            ProducerId = 5,
        //            Title = "All The Right Moves",
        //            StartDate = new DateTime(2023, 9, 25),
        //            CompleteDate = "2024-03-25",
        //            IsComplete = false,
        //            KeyId = 9,
        //            Bpm = 115,
        //            Notes = "This is for a pop pitch, so no country elements.",
        //            Lyric = "All the right friends in all the right places\nSo yeah, we're goin' down\nThey got all the right moves in all the right faces\nSo yeah, we're goin' down\nLet's paint the picture of the perfect place\nThey got it better than what anyone's told you\nThey'll be the King of Hearts, and you're the Queen of Spades\nThen we'll fight for you like we were your soldiers\nI know we got it good, but they got it made\nAnd their grass is getting greener each day\nI know things are looking up, but soon they'll take us down\nBefore anybody's knowin' our name\nThey got all the right friends in all the right places\nSo yeah, we're goin' down\nThey got all the right moves in all the right faces\nSo yeah, we're goin' down",
        //            Worktape = "worktape_iota.mp3",
        //            PaymentTypeId = 3
        //        },
        //        new Project
        //        {
        //            Id = 10,
        //            CustomerId = 2,
        //            ProducerId = 1,
        //            Title = "Sky Full Of Stars",
        //            StartDate = new DateTime(2023, 10, 5),
        //            CompleteDate = "2024-04-05",
        //            IsComplete = false,
        //            KeyId = 10,
        //            Bpm = 122,
        //            Notes = "This is a special one to me, hoping to have it played for my fiance.",
        //            Lyric = "'Cause you're a sky, 'cause you're a sky full of stars\nI'm gonna give you my heart\n'Cause you're a sky, 'cause you're a sky full of stars\n'Cause you light up the path\nI don't care, go on and tear me apart\nI don't care if you do, ooh-ooh, ooh\n'Cause in a sky, 'cause in a sky full of stars\nI think I saw you\n'Cause you're a sky, 'cause you're a sky full of stars\nI wanna die in your arms, oh, oh-oh\n'Cause you get lighter the more it gets dark\nI'm gonna give you my heart, oh",
        //            Worktape = "worktape_kappa.mp3",
        //            PaymentTypeId = 1
        //        },
        //        new Project
        //        {
        //            Id = 11,
        //            CustomerId = 4,
        //            ProducerId = 3,
        //            Title = "Barefoot Blue Jean Night",
        //            StartDate = new DateTime(2023, 11, 10),
        //            CompleteDate = "2024-05-10",
        //            IsComplete = false,
        //            KeyId = 11,
        //            Bpm = 138,
        //            Notes = "I think some steel and a banjo would be great on this.",
        //            Lyric = "A full moon shinin' bright\nEdge of the water, we were feelin' alright\nBack down a country road\nThe girls are always hot, and the beer is ice cold\nCadillac, horns on the hood\nMy buddy Frankie had his dad hook him up good\nGirls smile when we roll by\nThey hop in the back, and we cruise to the river side\nNever gonna grow up (Whoa-oh)\nNever gonna slow down (Whoa-oh)\nWe were shinin' like lighters in the dark\nIn the middle of a rock show (Whoa-oh)\nWe were doin' it right (Whoa-oh)\nWe were comin' alive (Whoa-oh)\nYeah, caught in a southern summer, barefoot, blue jean night",
        //            Worktape = "worktape_lambda.mp3",
        //            PaymentTypeId = 2
        //        },
        //        new Project
        //        {
        //            Id = 12,
        //            CustomerId = 6,
        //            ProducerId = 5,
        //            Title = "Sweet Thing",
        //            StartDate = new DateTime(2023, 12, 15),
        //            CompleteDate = "2024-06-15",
        //            IsComplete = false,
        //            KeyId = 12,
        //            Bpm = 130,
        //            Notes = "This is just the first draft of the lyrics. Once the instrumental is done, I'll send a final lyric.",
        //            Lyric = "When I picked you up for our first date baby\nWell, your pretty blue eyes, they were drivin' me crazy\nAnd the tiny little thought that was so amazing\nIs they were looking at me.\nI held open the car door for you then you climbed\nInside and slid on over\nTo the other side, I thought my, oh my\nSweet thing\nThe moon is high and the night is young\nCome on and meet me\nIn the backyard under the Cottonwood tree\nIt's a good thing and I'm wishing\nC'mon sweet thing\nWon't you climb on out of your window\nWhile the world is sleeping\nYou know I need you\nAnd there's no way I'll be leaving\n'Till we're kissing on the porch swing\nOh my little sweet thing",
        //            Worktape = "worktape_mu.mp3",
        //            PaymentTypeId = 3
        //        }
        //    });

        //modelBuilder.Entity<ProducerService>().HasData(new ProducerService[]
        //    {
        //        new ProducerService
        //        {
        //            Id = 1,
        //            ProducerId = 1,
        //            ServiceId = 1,
        //            Price = 100M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 2,
        //            ProducerId = 1,
        //            ServiceId = 2,
        //            Price = 150M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 3,
        //            ProducerId = 3,
        //            ServiceId = 1,
        //            Price = 200M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 4,
        //            ProducerId = 3,
        //            ServiceId = 3,
        //            Price = 180M,
        //            Active = false
        //        },
        //        new ProducerService
        //        {
        //            Id = 5,
        //            ProducerId = 5,
        //            ServiceId = 2,
        //            Price = 130M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 6,
        //            ProducerId = 5,
        //            ServiceId = 3,
        //            Price = 160M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 7,
        //            ProducerId = 1,
        //            ServiceId = 4,
        //            Price = 120M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 8,
        //            ProducerId = 3,
        //            ServiceId = 4,
        //            Price = 220M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 9,
        //            ProducerId = 5,
        //            ServiceId = 1,
        //            Price = 140M,
        //            Active = false
        //        },
        //        new ProducerService
        //        {
        //            Id = 10,
        //            ProducerId = 1,
        //            ServiceId = 5,
        //            Price = 170M,
        //            Active = true
        //        },
        //        new ProducerService
        //        {
        //            Id = 11,
        //            ProducerId = 3,
        //            ServiceId = 5,
        //            Price = 190M,
        //            Active = false
        //        },
        //        new ProducerService
        //        {
        //            Id = 12,
        //            ProducerId = 5,
        //            ServiceId = 5,
        //            Price = 210M,
        //            Active = true
        //        }

        //    });

        //modelBuilder.Entity<Service>().HasData(new Service[]
        //    {
        //        new Service { Id = 1, Name = "Recording", Description = "Recording service for tracks" },
        //        new Service { Id = 2, Name = "Mixing", Description = "Mixing service for tracks" },
        //        new Service { Id = 3, Name = "Mastering", Description = "Mastering service for tracks" },
        //        new Service { Id = 4, Name = "Editing", Description = "Editing service for tracks" },
        //        new Service { Id = 5, Name = "Producing", Description = "Producing service for tracks" },
        //        new Service { Id = 6, Name = "Songwriting", Description = "Songwriting service for tracks" },
        //        new Service { Id = 7, Name = "Arrangement", Description = "Arrangement service for tracks" },
        //        new Service { Id = 8, Name = "Consultation", Description = "Consultation for music projects" },
        //        new Service { Id = 9, Name = "Live Recording", Description = "Live recording service" },
        //        new Service { Id = 10, Name = "Rehearsal", Description = "Rehearsal space service" },
        //        new Service { Id = 11, Name = "Vocal Tuning", Description = "Vocal tuning service" },
        //        new Service { Id = 12, Name = "Session Musician", Description = "Session musician service" }
        //    });

        //modelBuilder.Entity<Key>().HasData(new Key[]
        //     {
        //        new Key { Id = 1, Name = "C Major" },
        //        new Key { Id = 2, Name = "G Major" },
        //        new Key { Id = 3, Name = "D Major" },
        //        new Key { Id = 4, Name = "A Major" },
        //        new Key { Id = 5, Name = "E Major" },
        //        new Key { Id = 6, Name = "B Major" },
        //        new Key { Id = 7, Name = "F# Major" },
        //        new Key { Id = 8, Name = "Db Major" },
        //        new Key { Id = 9, Name = "Ab Major" },
        //        new Key { Id = 10, Name = "Eb Major" },
        //        new Key { Id = 11, Name = "Bb Major" },
        //        new Key { Id = 12, Name = "F Major" },
        //        new Key { Id = 13, Name = "A Minor" },
        //        new Key { Id = 14, Name = "E Minor" },
        //        new Key { Id = 15, Name = "B Minor" },
        //        new Key { Id = 16, Name = "F# Minor" },
        //        new Key { Id = 17, Name = "C# Minor" },
        //        new Key { Id = 18, Name = "G# Minor" },
        //        new Key { Id = 19, Name = "D# Minor" },
        //        new Key { Id = 20, Name = "A# Minor" },
        //        new Key { Id = 21, Name = "D Minor" },
        //        new Key { Id = 22, Name = "G Minor" },
        //        new Key { Id = 23, Name = "C Minor" },
        //        new Key { Id = 24, Name = "F Minor" }

        //    });

    //    modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
    //        {
    //            new PaymentType { Id = 1, Type = "Credit Card" },
    //            new PaymentType { Id = 2, Type = "PayPal" },
    //            new PaymentType { Id = 3, Type = "Bank Transfer" }
    //        });

    //}


    public EMGDbContext(DbContextOptions<EMGDbContext> context) : base(context)
    {

    }
}
 