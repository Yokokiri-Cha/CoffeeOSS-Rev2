using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Forms;
using System.Windows.Shell;
using Microsoft.Web.WebView2.Core;
using SpeechLib;

namespace COSS
{
    
    public partial class Form1 : Form
    {
        Form2 mkqr;
        maximizedsc mx;
        Form3 lic;
        //UASというクラスの中にアクセス装飾子がPublicの文字列UAを保存
        //呼び出す時はインスタンスを作成する
        public class UAS
        {
            public string UA;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //webView21.CoreWebView2.Navigate("https://google.co.jp/");
            //https://atmarkit.itmedia.co.jp/ait/articles/1509/09/news025.html参照しました。ありがとうございます!
            //JumpListメニューの実装
            var jl = new System.Windows.Shell.JumpList();
            var jt = new System.Windows.Shell.JumpTask()
            {
                CustomCategory = "CoffeeOSSセッションメニュー",
                Title = "新しいセッションを開始",
                Description = "ウィンドウを重複起動し、新規セッションを開始します。",
            };

            jl.JumpItems.Add(jt);
            jl.Apply();

        }

        private void webView22_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            //UASクラスをduaと名づける
            UAS dua = new UAS();
            //dua内のUAという文字列ストアに既定のUserAgentを格納
            //後に使用します。
            dua.UA = webView22.CoreWebView2.Settings.UserAgent;
            webView22.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text+"をグーグルで検索します", fl);
            }
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Google)
                string baseline = "https://www.google.com/search?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);

            }
            else
            {
                //ユーザー入力文字列変数usr→URLエンコード処理済みはusr6に格納。
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Google)
                string baseline = "https://www.google.com/search?q=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をダックダックゴーで検索します", fl);
            }
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(DuckDuckGo)
                string baseline = "https://duckduckgo.com/?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(DuckDuckGo)
                string baseline = "https://duckduckgo.com/?q=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をユーチューブで検索します", fl);
            }
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTube)
                string baseline = "https://www.youtube.com/results?search_query=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            { 
            string usr = this.textBox1.Text;
            string usr2 = usr.Replace("+", "%2B");
            string usr3 = usr2.Replace("　", "+");
            string usr4 = usr3.Replace(" ", "+");
            string usr5 = usr4.Replace("#", "%23");
            string usr6 = usr5.Replace("*", "%2A");
            //先頭付加用検索エンジンURL(YouTube)
            string baseline = "https://www.youtube.com/results?search_query=";
            webView21.CoreWebView2.Navigate(baseline + usr6);
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string usr6 = this.textBox1.Text;
                if (usr6.Contains("."))
                {
                    if (usr6.Contains("http"))
                    {
                        if (invisiblestore.Checked)
                        {
                            SpVoice syab = new SpVoice();

                            SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                            syab.Speak("ご指定のURL先のサイトへ移動します", fl);
                        }
                        webView22.CoreWebView2.Navigate(usr6);
                    }
                    else
                    {
                        if (invisiblestore.Checked)
                        {
                            SpVoice syab = new SpVoice();

                            SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                            syab.Speak("不完全なURLを検出しました。ダイアログボックスを閉じるとhttpsモードで続行します", fl);
                        }
                        MessageBox.Show("httpやhttpsの省略を検知しました。httpsモードで続行します。アクセス不可の場合はhttp://をURLの先頭に付加して下さい。");
                        string usr7 = "https://" + usr6;
                        webView22.CoreWebView2.Navigate(usr7);


                    }

                }
                else
                {
                    if (invisiblestore.Checked)
                    {
                        SpVoice syab = new SpVoice();

                        SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                        syab.Speak("ご指定のURL先のサイトへの移動が出来ませんでした。", fl);
                    }
                    MessageBox.Show("指定されたURLは無効である可能性があります。ご確認下さい。\nErr:Malformed URL");
                }
            }
            else
            {
                string usr6 = this.textBox1.Text;
                if (usr6.Contains("."))
                {
                    if (usr6.Contains("http"))
                    {
                        webView21.CoreWebView2.Navigate(usr6);
                    }
                    else
                    {
                        MessageBox.Show("httpやhttpsの省略を検知しました。httpsモードで続行します。アクセス不可の場合はhttp://をURLの先頭に付加して下さい。");
                        string usr7 = "https://" + usr6;
                        webView21.CoreWebView2.Navigate(usr7);


                    }

                }
                else
                {
                    MessageBox.Show("指定されたURLは無効である可能性があります。ご確認下さい。\nErr:Malformed URL");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をユーチューブミュージックで楽曲検索します", fl);
            }
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTubeMusic)
                string baseline = "https://music.youtube.com/search?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            { 

            string usr = this.textBox1.Text;
            string usr2 = usr.Replace("+", "%2B");
            string usr3 = usr2.Replace("　", "+");
            string usr4 = usr3.Replace(" ", "+");
            string usr5 = usr4.Replace("#", "%23");
            string usr6 = usr5.Replace("*", "%2A");
            //先頭付加用検索エンジンURL(YouTubeMusic)
            string baseline = "https://music.youtube.com/search?q=";
            webView21.CoreWebView2.Navigate(baseline + usr6);
        }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をニコニコ動画で検索します", fl);
            }
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Nicovideo)
                string baseline = "https://www.nicovideo.jp/search/";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            { 
            string usr = this.textBox1.Text;
            string usr2 = usr.Replace("+", "%2B");
            string usr3 = usr2.Replace("　", "+");
            string usr4 = usr3.Replace(" ", "+");
            string usr5 = usr4.Replace("#", "%23");
            string usr6 = usr5.Replace("*", "%2A");
            //先頭付加用検索エンジンURL(Nicovideo)
            string baseline = "https://www.nicovideo.jp/search/";
            webView21.CoreWebView2.Navigate(baseline + usr6);
        }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("文字を削除しました。", fl);
            }
            textBox1.Text= string.Empty;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("戻るボタンを押しました", fl);
            }
            //戻る
            webView21.CoreWebView2.GoBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("新規セッションを開始しました。", fl);
            }
            Form1 fa = new Form1();
            fa.Show();
        }

        private void toolStripLabel13_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("完全終了します。ご利用いただきありがとうございました。またのご利用をお待ちしています。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを終了します。");
                Application.Exit();
            }
            else
            {
            Application.Exit();
            }

        }

        private void タスクマネージャーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ブラウザーのタスクマネージャーを開きます", fl);
            }
            webView21.CoreWebView2.OpenTaskManagerWindow();
        }

        private void fastPortalBy横茶横葉へ移動ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("よこちゃよこはが製作した最軽量汎用ポータルサイトへ移動します", fl);
            }
            //横茶横葉の最軽量ポータルサイトへ移動します。//PCスペックを考慮せず、快適に使えるようにする工夫です!
            webView21.CoreWebView2.Navigate("https://yokochayokoha.github.io/fastportal");
        }

        private void 詳細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("アプリの詳細を表示します", fl);
            }
            MessageBox.Show("©2023 横茶横葉\nAndroid版Coffeeブラウザーと同様の操作感をWindowsでも!\nオープンソースで安心なブラウジングを第一に考えて製作された軽量のブラウザーです!\n//横茶横葉より//ご利用頂きありがとうございます!!Android版Coffeeブラウザーもどうぞよろしくお願い致します!!\nPlease visit!:yokochayokoha.github.io");
        }

        private void ソフトウェア配布ページへToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("このブラウザーのソースコードを表示します", fl);
            }
            webView21.CoreWebView2.Navigate("https://github.com/Yokokiri-Cha/CoffeeOSS");
        }

        private void このアプリについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("アプリの詳細を表示します", fl);
            }
            MessageBox.Show("©2023 横茶横葉\nAndroid版Coffeeブラウザーと同様の操作感をWindowsでも!\nオープンソースで安心なブラウジングを第一に考えて製作された軽量のブラウザーです!\n//横茶横葉より//ご利用頂きありがとうございます!!Android版Coffeeブラウザーもどうぞよろしくお願い致します!!\nPlease visit!:yokochayokoha.github.io");
        }

        private void toolStripLabel12_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("全画面表示に切り替えます", fl);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripLabel11_Click(object sender, EventArgs e)
        {
            
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("操作パネルを隠します", fl);
            }


            toolStrip1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;

          //  notifyIcon1.ShowBalloonTip(5);
        }

        private void 操作バーの再表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            toolStrip1.Visible = true;

            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;

            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            webView21.Dock = DockStyle.None;
            this.FormBorderStyle = FormBorderStyle.Sizable;
 
        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("印刷プレビュー画面を表示します", fl);
            }
            webView21.CoreWebView2.ShowPrintUI();
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ダウンロード中のファイルの進捗状況を表示します", fl);
            }
            webView21.CoreWebView2.OpenDefaultDownloadDialog();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            //JS無効化による簡易広告ブロック機能from Coffee(for Android)
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("広告ブロック機能のオンオフを切り替えます", fl);
            }
            if (toolStripLabel6.Text.Contains("無効"))
            {
                //文字列でオンオフの判定
                toolStripLabel6.Text = "簡易広告ブロック(現在:有効)";
                webView21.CoreWebView2.Settings.IsScriptEnabled = false;
                webView21.CoreWebView2.Reload();
            }
            else
            {
                toolStripLabel6.Text = "簡易広告ブロック(現在:無効)";
                webView21.CoreWebView2.Settings.IsScriptEnabled = true;
                webView21.CoreWebView2.Reload();
            }
        }

        private void iOSモードiOS16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1";
            webView21.CoreWebView2.Reload();
        }

        private void googleChromeモード116ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
            webView21.CoreWebView2.Reload();
        }

        private void safariモード16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.3 Safari/605.1.15";
            webView21.CoreWebView2.Reload();
        }

        private void firefoxモード117ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/119.0";
            webView21.CoreWebView2.Reload();
        }

        private void androidモードAndroid13TiramisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Linux; Android 13; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Mobile Safari/537.36";
            webView21.CoreWebView2.Reload();
        }

        private void 既定のユーザーエージェントToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  UAS dua = new UAS();
            //webView21.CoreWebView2.Settings.UserAgent = dua.UA;
            //webView21.CoreWebView2.Reload();
            MessageBox.Show("お手数ですが、ブラウザーを再起動してください。元のユーザーエージェントに戻ります。");
        }

        private void 適用するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("テキストが入力されていません。誤動作を防止するため、処理を行いませんでした。/Err:No text");
            }
            else
            {
                webView21.CoreWebView2.Settings.UserAgent = toolStripTextBox1.Text;
                webView21.CoreWebView2.Reload();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ホームページボタンを押しました。", fl);
            }
            //ホーム(Google)
            webView21.CoreWebView2.Navigate("https://google.co.jp");

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("進むボタンを押しました", fl);
            }
            //進む
            webView21.CoreWebView2.GoForward();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("更新ボタンを押しました", fl);
            }
            //再読み込み
            webView21.CoreWebView2.Reload();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("QRコードを作成します", fl);
            }
            //QRコード生成from速作成QR
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView21.CoreWebView2.Source;
            mkqr.Show();
        }

        private void toolStripLabel14_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("新規セッションを開始します。", fl);
            }
            Form1 fa = new Form1();
            fa.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("このバーはアップラインと呼ばれる操作パネルです。", fl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (invisiblestore.Checked)
            {
                invisiblestore.Checked = false;

                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("こちらは音声リーダーアクセシビリティーサービスです。読み上げ機能を無効化しました。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを無効化しました。");
            }
            else 
            {
                invisiblestore.Checked = true;

                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("こちらは音声リーダーアクセシビリティーサービスです。読み上げ機能を有効化しました。おこなった操作内容を音声で読み上げます。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを有効化しました。無効化するにはもう一度ロゴマークをクリックして下さい。");
            }
            //https://www.kyoukasho.net/entry/csharp-textToSpeech参照。ありがとうございます!

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("変更しました", fl);
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ユーザーエージェントの設定項目を表示します", fl);
            }
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("開発者向けツールを開きます", fl);
            }
            webView21.CoreWebView2.OpenDevToolsWindow();
        }

        private void オープンソースライセンス表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("オープンソースライセンスを表示します", fl);
            }
            lic = new Form3();
            lic.Show();
        }

        private void toolStripLabel2_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用戻るアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch戻る";
            webView22.CoreWebView2.GoBack();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            toolStripLabel1.Text = "Upline";
        }

        private void toolStripLabel3_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用ホームアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearchホーム";
            webView22.CoreWebView2.Navigate("https://yokokiri-cha.github.io/minisearch");
            timer1.Enabled = true;
        }

        private void toolStripLabel4_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用進むアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch進む";
            webView22.CoreWebView2.GoForward();
            timer1.Enabled = true;
        }

        private void toolStripLabel5_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用更新アクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch更新";
            webView22.CoreWebView2.Reload();
            timer1.Enabled = true;
        }

        private void toolStripLabel7_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用QRコード作成アクションを指定しました", fl);
            }
            //QRコード生成from速作成QR
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView22.CoreWebView2.Source;
            mkqr.Show();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            timer2.Enabled = true;
            webView21.CoreWebView2.NewWindowRequested += sosi;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox2.Text = webView21.CoreWebView2.DocumentTitle;
            textBox3.Text = webView21.CoreWebView2.Source;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tenso1 = webView21.CoreWebView2.Source;
            string tenso2 = webView22.CoreWebView2.Source;
            webView21.CoreWebView2.Navigate(tenso2);
            webView22.CoreWebView2.Navigate(tenso1);
        }
        //別Window表示防止(https://web.biz-prog.net/praxis/webview/linkself.htmlプログラムでネットサーフィン様のコードの一部を使用しました。ありがとうございます!)

        private void sosi(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {

            e.Handled = true;


            webView21.CoreWebView2.Navigate(e.Uri);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox2.Text, true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox3.Text, true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            webView22.GoBack();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            webView22.GoForward();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            webView22.CoreWebView2.Navigate("https://yokokiri-cha.github.io/minisearch");
        }

        private void toolStripLabel11_Click_1(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("全画面で表示します", fl);
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("無効なURLです。");
            }
            else
            {
                mx = new maximizedsc();
                mx.label1.Text = textBox3.Text;
                mx.Show();
                mx.TopMost = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
        //esc key function not work
            Application.Exit();
        }
    }
}
