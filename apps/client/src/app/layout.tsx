import type { Metadata } from 'next';
import './globals.css';

export const metadata: Metadata = {
  title: 'Movie App',
  description: 'A Database of Movies',
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
