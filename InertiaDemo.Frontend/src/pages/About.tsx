import { Navigation } from '../components/Navigation';
import { page } from '../utils/page';
import type { AboutDto } from '../types/dtos/about-dto';

const About = page<AboutDto>(({ title }) => {
  return (
    <>
      <Navigation />
      <p>{title}</p>
    </>
  );
});

export default About;
